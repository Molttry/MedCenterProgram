using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DocuSign.eSign.Model;

namespace MedCenterProgram
{
    public class Menu
    {
        public void ListOfEmployees()
        {
            using (var listing = new StreamReader(@"B:\VisualRepos\ListofPeople.txt"))
            {
                List<string> line = new List<string>();
                string buffer = " ";
                do
                {
                    Console.WriteLine();
                    buffer = listing.ReadLine();
                    if (buffer == null) break;
                    foreach (var word in buffer.Split("/"))
                    {
                        line.Add(word);
                    }
                    foreach (var word in line)
                    {
                        Console.Write(word + " ");
                    }
                    line.Clear();
                } while (buffer != null);
            }
        }
        public void ListOfDuties()
        {

        }
        public void AddDuty()
        {
            using (var listing = new StreamReader(@"B:\VisualRepos\ListofPeople.txt"))
            {
                Nurse_Admin nurse_admin = new Nurse_Admin();
                Doctor doctor = new Doctor();
                List<Nurse_Admin> nurses_admins = new List<Nurse_Admin>();
                List<Doctor> doctors = new List<Doctor>();
                List<string> line = new List<string>();
                string buffer = " ";
                string[] list;
                do
                {
                    Console.WriteLine();
                    buffer = listing.ReadLine();
                    if (buffer == null) break;
                    foreach (var word in buffer.Split("/"))
                    {
                        line.Add(word);
                    }
                    foreach (var word in line)
                    {
                        Console.Write(word + " ");
                        if (word == "doctor")
                        {
                            list = line.ToArray();
                            doctors.Add(new Doctor()
                            {
                                name = list[0],
                                type = list[1],
                                profession = list[2],
                                duty = doctor.Fill(list)
                            });
                        }
                        if (word == "nurse" || word == "admin")
                        {
                            list = line.ToArray();
                            nurses_admins.Add(new Nurse_Admin()
                            {
                                name = list[0],
                                type = list[1],
                                duty = nurse_admin.Fill(list)

                            });
                        }
                    }
                    line.Clear();
                } while (buffer != null);
                Console.WriteLine("Choose stuff to add duty by entering the name:");
                string input = Console.ReadLine();
                nurses_admins.
            }
        }
    }
}
