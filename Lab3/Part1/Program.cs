using Part1.Models;
using System;
using System.Collections.Generic;

namespace Part1
{
    class Program
    {
        private static Component InitFaculty()
        {
            return new Faculty
            {
                FacultyName = "FPM",
                Courses = new List<Course>
                {
                    new Course
                    {
                        CourseName = "Computer system engineering",
                        Streams = new List<CourseStream>
                        {
                            new CourseStream
                            {
                                StreamName = "KP-1x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KP-11",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KP-12",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                            new CourseStream
                            {
                                StreamName = "KP-0x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KP-01",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KP-02",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                            new CourseStream
                            {
                                StreamName = "KP-9x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KP-91",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KP-92",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                        }
                    },

                    new Course
                    {
                        CourseName = "Applied Math",
                        Streams = new List<CourseStream>
                        {
                            new CourseStream
                            {
                                StreamName = "KA-1x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KA-11",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89,  }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KA-12",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                            new CourseStream
                            {
                                StreamName = "KA-0x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KA-01",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 88.75, 0, 15 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KA-02",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                            new CourseStream
                            {
                                StreamName = "KA-9x",
                                Groups = new List<Group>
                                {
                                    new Group
                                    {
                                        GroupName = "KA-91",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro3",
                                                Lastname = "Petrenko3",
                                                Middlename = "Petrovych3",
                                                Grades = new double[]{ 50, 100, 14, 78, 89, 56.5, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro4",
                                                Lastname = "Petrenko4",
                                                Middlename = "Petrovych4",
                                                Grades = new double[]{ 50, 90, 14, 78, 89, 56.5, 88.75 }
                                            },
                                        }
                                    },

                                    new Group
                                    {
                                        GroupName = "KA-92",
                                        Students = new List<Student>
                                        {
                                            new Student
                                            {
                                                Firstname = "Petro1",
                                                Lastname = "Petrenko1",
                                                Middlename = "Petrovych1",
                                                Grades = new double[]{ 50, 100, 14, 88.75 }
                                            },
                                            new Student
                                            {
                                                Firstname = "Petro2",
                                                Lastname = "Petrenko2",
                                                Middlename = "Petrovych2",
                                                Grades = new double[]{ 89, 56.5, 88.75 }
                                            },

                                            new Student
                                            {
                                                Firstname = "Petro0",
                                                Lastname = "Petrenko0",
                                                Middlename = "Petrovych0",
                                                Grades = new double[]{ 14, 78, 56.5, 88.75 }
                                            },
                                        }
                                    }
                                }
                            },

                        }
                    },
                }
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{InitFaculty().Avg():f2}");
        }
    }
}
