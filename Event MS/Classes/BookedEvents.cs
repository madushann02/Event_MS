using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    internal class BookedEvents : Events
    {
        private string bookingid;
        private string memberid;

        public string BookingId
        {
            get => bookingid;
            set => bookingid = value;
        }
        public string MemberId
        {
            get => memberid;
            set => memberid = value;
        }

        public BookedEvents(string bookingid, string eventid, string eventname, string eventtype, string memberid)
            : base(eventid, eventname, eventtype)
        {
            this.bookingid = bookingid;
            this.memberid = memberid;
        }

        //create data base connection
        private static readonly string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add booked events to the database
        public void BookEvent()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check the available tickets for the event
                    const string checkAvailabilityQuery = "SELECT ticketsavailable FROM manageevents WHERE eventid = @eventid";
                    using (var checkCmd = new MySqlCommand(checkAvailabilityQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@eventid", this.EventId);
                        int ticketsAvailable = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If no tickets are available, show message and stop the booking
                        if (ticketsAvailable <= 0)
                        {
                            MessageBox.Show("Tickets are sold out for this event.");
                            return;
                        }
                    }

                    // Update tickets available for the event
                    const string updateTicketsQuery = "UPDATE manageevents SET ticketsavailable = ticketsavailable - 1 WHERE eventid = @eventid";

                    // Insert booking details into the bookedevents table
                    const string insertBookingQuery = "INSERT INTO bookedevents (eventid, memberid, eventname, eventtype) VALUES (@eventid, @memberid, @eventname, @eventtype)";

                    // Insert booked event details
                    using (var cmd = new MySqlCommand(insertBookingQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventid", this.EventId);
                        cmd.Parameters.AddWithValue("@memberid", this.MemberId);
                        cmd.Parameters.AddWithValue("@eventname", this.EventName);
                        cmd.Parameters.AddWithValue("@eventtype", this.EventType);
                        cmd.ExecuteNonQuery();
                    }

                    // Update the tickets available
                    using (var cmd = new MySqlCommand(updateTicketsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventid", this.EventId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Event Booked successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error booking event: " + ex.Message);
                }
            }
        }

        // Retrieve all booked events from the database
        public static List<BookedEvents> AllBookedEvents(string memberId)
        {
            var bookedEvents = new List<BookedEvents>();

            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    const string query = "SELECT * FROM bookedevents WHERE memberid = @memberid";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@memberid", memberId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bookedEvents.Add(new BookedEvents(
                                    reader["bookingid"].ToString(),
                                    reader["eventid"].ToString(),
                                    reader["eventname"].ToString(),
                                    reader["eventtype"].ToString(),
                                    reader["memberid"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving booked events: " + ex.Message);
                }
            }

            return bookedEvents;
        }

        // Method to delete an event from the database
        public static void DeleteEventById(int bookingid)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    const string query = "DELETE FROM bookedevents WHERE bookingid = @bookingid";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingid", bookingid);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting event: " + ex.Message);
                }
            }
        }
    }
}
