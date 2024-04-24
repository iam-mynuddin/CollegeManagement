export class Attendance {
  constructor(
    public AttendanceId: number,
    public AttendanceDate: Date,
    public StudentId: number,
    public FacultyId: number,
    public IsPresent: boolean
  )
  { }
  }
