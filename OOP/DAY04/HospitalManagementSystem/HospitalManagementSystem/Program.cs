using System;
using System.Collections.Generic;

// Define the IStaff interface
public interface IStaff
{
    int StaffID { get; set; }
    string Name { get; set; }
    string Department { get; set; }

    void AssignTask(string task);
    void DisplayDetails();
}

// Doctor class implementing IStaff
public class Doctor : IStaff
{
    public int StaffID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    private string Specialization { get; set; }
    private List<string> Appointments { get; set; }

    public Doctor()
    {
        Appointments = new List<string>();
    }

    public void SetSpecialization(string specialization)
    {
        Specialization = specialization;
    }

    public string GetSpecialization()
    {
        return Specialization;
    }

    public void AddAppointment(string appointment)
    {
        Appointments.Add(appointment);
    }

    public void DisplayAppointments()
    {
        Console.WriteLine($"Appointments for Dr. {Name}:");
        foreach (var appointment in Appointments)
        {
            Console.WriteLine(appointment);
        }
    }

    public void AssignTask(string task)
    {
        Console.WriteLine($"Doctor {Name} has been assigned the task: {task}");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Doctor: {Name}, Department: {Department}, Specialization: {Specialization}");
    }
}

// Nurse class implementing IStaff
public class Nurse : IStaff
{
    public int StaffID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    private int ShiftHours { get; set; }

    public void SetShiftHours(int hours)
    {
        ShiftHours = hours;
    }

    public int GetShiftHours()
    {
        return ShiftHours;
    }

    public void AssignTask(string task)
    {
        Console.WriteLine($"Nurse {Name} has been assigned the task: {task}");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Nurse: {Name}, Department: {Department}, Shift Hours: {ShiftHours}");
    }
}

// Technician class implementing IStaff
public class Technician : IStaff
{
    public int StaffID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    private string Expertise { get; set; }

    public void SetExpertise(string expertise)
    {
        Expertise = expertise;
    }

    public string GetExpertise()
    {
        return Expertise;
    }

    public void AssignTask(string task)
    {
        Console.WriteLine($"Technician {Name} with expertise in {Expertise} has been assigned the task: {task}");
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Technician: {Name}, Department: {Department}, Expertise: {Expertise}");
    }
}

// Main program to demonstrate functionality
class Program
{
    static void Main(string[] args)
    {
        // Create instances of staff
        Doctor doctor = new Doctor { StaffID = 1, Name = "Dr. Smith", Department = "Cardiology" };
        doctor.SetSpecialization("Heart Surgery");
        doctor.AddAppointment("Surgery at 10 AM");
        doctor.AddAppointment("Follow-up with patient at 2 PM");

        Nurse nurse = new Nurse { StaffID = 2, Name = "Nurse Jane", Department = "ICU" };
        nurse.SetShiftHours(8);

        Technician technician = new Technician { StaffID = 3, Name = "Tech Bob", Department = "Radiology" };
        technician.SetExpertise("X-Ray");

        // Assign tasks
        doctor.AssignTask("Perform surgery at 10 AM");
        nurse.AssignTask("Monitor patient in ICU");
        technician.AssignTask("Maintain X-Ray machine");

        // Display details
        doctor.DisplayDetails();
        doctor.DisplayAppointments();

        nurse.DisplayDetails();
        technician.DisplayDetails();
    }
}
