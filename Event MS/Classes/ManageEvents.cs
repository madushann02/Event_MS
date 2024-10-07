﻿using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    internal class ManageEvents : Events
    {
        private string venue;
        private string ticketprice;
        private string ticketsavailable;

        public string Venue
        {
            get { return venue; }
            set { venue = value; }
        }
        public string TicketPrice
        {
            get { return ticketprice; }
            set { ticketprice = value; }
        }
        public string TicketsAvailable
        {
            get { return ticketsavailable; }
            set { ticketsavailable = value; }
        }

        public ManageEvents(string eventid, string eventname, string venue, string eventtype, string ticketprice, string ticketsavailable)
            : base(eventid, eventname, eventtype)
        {
            this.venue = venue;
            this.ticketprice = ticketprice;
            this.ticketsavailable = ticketsavailable;
        }

        // Create database connection string
        private static readonly string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add event to database
        public static void AddEvent(ManageEvents events)
        {
            if (events is ManageEvents manageEvents)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check the number of events in the database
                        string countQuery = "SELECT COUNT(*) FROM manageevents";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int eventCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            // Check if the number of events is less than 20
                            if (eventCount >= 20)
                            {
                                MessageBox.Show("The event limit of 20 has been reached. No more events can be added.");
                                return;
                            }
                        }

                        // Add event to database
                        string query = "INSERT INTO manageevents (eventname, eventtype, eventvenue, ticketprice, ticketsavailable) VALUES (@eventname, @eventtype, @venue, @ticketprice, @ticketsavailable)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@eventname", manageEvents.EventName);
                            cmd.Parameters.AddWithValue("@eventtype", manageEvents.EventType);
                            cmd.Parameters.AddWithValue("@venue", manageEvents.Venue);
                            cmd.Parameters.AddWithValue("@ticketprice", manageEvents.TicketPrice);
                            cmd.Parameters.AddWithValue("@ticketsavailable", manageEvents.TicketsAvailable);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Event has been added!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding event: " + ex.Message);
                    }
                }
            }
        }

        // Retrieve all events from database
        public static List<ManageEvents> GetAllEvents()
        {
            List<ManageEvents> manageEvents = new List<ManageEvents>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM manageevents";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                manageEvents.Add(new ManageEvents(
                                    reader["eventid"].ToString(),
                                    reader["eventname"].ToString(),
                                    reader["eventtype"].ToString(),
                                    reader["eventvenue"].ToString(),
                                    reader["ticketprice"].ToString(),
                                    reader["ticketsavailable"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving events: " + ex.Message);
                }
            }
            return manageEvents;
        }

        // Delete event from database
        public static void DeleteEvent(int eventId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM manageevents WHERE eventid = @eventId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventId", eventId);
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
