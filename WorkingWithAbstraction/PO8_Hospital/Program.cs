namespace PO8_Hospital
{
    using PO8_Hospital.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var doctors = new HashSet<Doctor>();
            var departments = new HashSet<Department>();
            var patients = new HashSet<Patient>();
            var endCommand = "Output";
            var command = String.Empty;
            while ((command = Console.ReadLine()) != endCommand)
            {
                var hospitalizedDetails = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var departmentName = hospitalizedDetails[0];
                var doctorFirstName = hospitalizedDetails[1];
                var doctorSurname = hospitalizedDetails[2];
                var patientName = hospitalizedDetails[3];

                if (!(doctors.Any(d => d.FirstName == doctorFirstName && d.Surname == doctorSurname)))
                {
                    var curDoctor = new Doctor(doctorFirstName, doctorSurname);
                    doctors.Add(curDoctor);
                }

                if (!(departments.Any(d => d.Name == departmentName)))
                {
                    var curDepartment = new Department(departmentName);
                    departments.Add(curDepartment);
                }

                if (!(patients.Any(p => p.Name == patientName)))
                {
                    var curPatient = new Patient(patientName);
                    patients.Add(curPatient);
                }

                var doctor = doctors.First(d => d.FirstName == doctorFirstName && d.Surname == doctorSurname);
                var department = departments.First(d => d.Name == departmentName);
                var patient = patients.First(p => p.Name == patientName);
                department.AddPatient(patient);
                doctor.AddPatient(patient);
            }

            var outputCriteria = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (outputCriteria.Length == 1)
            {
                var department = departments.First(d => d.Name == outputCriteria[0]);
                Console.WriteLine(String.Join(Environment.NewLine, department.Patients));
            }
            else if (doctors.Any(d => d.FirstName == outputCriteria[0]))
            {
                var doctor = doctors.First(d => d.FirstName == outputCriteria[0] && d.Surname == outputCriteria[1]);
                Console.WriteLine(String.Join(Environment.NewLine, doctor.Patients.OrderBy(p => p.Name)));
            }
            else
            {
                var department = departments.First(d => d.Name == outputCriteria[0]);
                var roomNumber = int.Parse(outputCriteria[1]);
                Console.WriteLine(String.Join(Environment.NewLine, department.Patients
                                                                               .Where(p => p.Room.Number == roomNumber)
                                                                               .OrderBy(p => p.Name)));
            }

        }
    }
}
