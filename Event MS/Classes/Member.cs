using MySql.Data.MySqlClient;

namespace Event_MS.Classes
{
    public class Member : User
    {
        private string id;
        private string email;
        private string tp;

        public string Id
        {
            get => id;
            set => id = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Tp
        {
            get => tp;
            set => tp = value;
        }

        public Member(string id, string name, string password, string email, string tp)
            : base(name, password)
        {
            this.id = id;
            this.email = email;
            this.tp = tp;
        }

        public override string GetRole() => "Member";

        // Create database connection string
        private static readonly string connectionString = "server=localhost;database=eventms;user=root;password=;";

        // Add member to database
        public static void AddMember(User user)
        {
            if (user is Member member)
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Check how many members are currently in the database
                        const string countQuery = "SELECT COUNT(*) FROM member";
                        using (var countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int memberCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            // Check if the number of members is less than 200
                            if (memberCount >= 200)
                            {
                                MessageBox.Show("The member limit of 200 has been reached. No more members can be added.");
                                return;
                            }
                        }

                        // Add member to database
                        const string query = "INSERT INTO member (ID, Name, password, email, tp) VALUES (@id, @name, @password, @email, @tp)";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", member.Id);
                            cmd.Parameters.AddWithValue("@name", member.Name);
                            cmd.Parameters.AddWithValue("@password", member.Password);
                            cmd.Parameters.AddWithValue("@email", member.Email);
                            cmd.Parameters.AddWithValue("@tp", member.Tp);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Member has registered!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding member: " + ex.Message);
                    }
                }
            }
        }

        // Get member details for login
        public static Member GetMember(string name, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    const string query = "SELECT * FROM member WHERE name = @name AND password = @password";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Member(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["password"].ToString(),
                                    reader["email"].ToString(),
                                    reader["tp"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving member: " + ex.Message);
                }
            }
            return null;
        }

        // Display all members in DashBoard tables
        public static List<Member> GetAllMembers()
        {
            var members = new List<Member>();
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    const string query = "SELECT * FROM member";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                members.Add(new Member(
                                    reader["id"].ToString(),
                                    reader["name"].ToString(),
                                    reader["password"].ToString(),
                                    reader["email"].ToString(),
                                    reader["tp"].ToString()
                                ));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving members: " + ex.Message);
                }
            }
            return members;
        }

        // Method to delete a member from the database
        public static void DeleteMemberById(int memberId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    const string query = "DELETE FROM member WHERE id = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", memberId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting member: " + ex.Message);
                }
            }
        }
    }
}
