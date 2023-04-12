using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
            */

            Doctor doctor1 = new Doctor("Armand", "Diabetología");
            Patient patient1 = new Patient("Steven Jhonson", "50884243", "", 22);
            Appointment appointment1 = new Appointment("1A", "Wall Street", DateTime.Now, patient1, doctor1); 
            //Console.WriteLine(appointment1.IsValid ? "App" : "Something went wrong");
            Console.WriteLine(appointment1);


        }
    }
}
