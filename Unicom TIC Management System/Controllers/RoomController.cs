using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace SchoolManageSystem.Controllers
{
    public class RoomController
    {
        // Get all rooms from the database
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT RoomID, RoomName, RoomType FROM Rooms", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        });
                    }
                }
            }

            return rooms;
        }

        // Add a new room with a unique RoomID
        public void AddRoom(Room room)
        {
            using (var conn = DbCon.GetConnection())
            {
                int randomId;
                Random rnd = new Random();

                // Generate a unique RoomID (range 101 to 299)
                do
                {
                    randomId = rnd.Next(101, 299);
                } while (RoomIdExists(randomId, conn));

                room.RoomID = randomId;

                var cmd = new SQLiteCommand("INSERT INTO Rooms (RoomID, RoomName, RoomType) VALUES (@RoomID, @RoomName, @RoomType)", conn);
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }

        // Update existing room details
        public void UpdateRoom(Room room)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @RoomID", conn);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete a room by RoomID
        public void DeleteRoom(int roomId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", conn);
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                cmd.ExecuteNonQuery();
            }
        }

        // Get a specific room by ID
        public Room GetRoomById(int roomId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT RoomID, RoomName, RoomType FROM Rooms WHERE RoomID = @RoomID", conn);
                cmd.Parameters.AddWithValue("@RoomID", roomId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        };
                    }
                }
            }

            return null;
        }

        // Check if RoomID already exists (to avoid duplicates)
        private bool RoomIdExists(int roomId, SQLiteConnection conn)
        {
            var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Rooms WHERE RoomID = @RoomID", conn);
            cmd.Parameters.AddWithValue("@RoomID", roomId);
            var count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
