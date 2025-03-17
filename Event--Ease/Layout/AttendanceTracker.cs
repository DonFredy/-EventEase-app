public class AttendanceTracker
{
   private Dictionary<string, bool> attendanceRecords = new();

   public void MarkAttendance(string userName)
   {
      if (!attendanceRecords.ContainsKey(userName))
      {
         attendanceRecords.Add(userName, true);
      }
   }

   public bool CheckAttendance(string userName)
   {
      return attendanceRecords.TryGetValue(userName, out var hasAttended) && hasAttended;
   }
}
