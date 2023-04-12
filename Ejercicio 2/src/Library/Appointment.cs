using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public string IdApp { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public bool IsValid { get; set; }

        public Appointment(string appointmentid, string place, DateTime date, Patient patient, Doctor doctor)
        {
            this.IsValid = Addme.AddMe(new string[] {appointmentid, place}) && patient.IsValid && doctor.IsValid;
            this.IdApp = appointmentid;
            this.Place = place;
            this.Date = date;
            this.Patient = patient;
            this.Doctor = doctor;
        }

        public override string ToString()
        {
            if (IsValid == true)
            {
                return $"Cita médica confirmada con éxito.\n Paciente: {this.Patient}\n Lugar: {this.Place}\n Hora de cita: {this.Date}\n Doctor: {this.Doctor}";
            }
            else
            {
                return "Algo salió mal.";
            }
        }

    }
}
