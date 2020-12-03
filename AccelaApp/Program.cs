using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AccelaApp
{ 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {
            Id = Id;
            FirstName = FirstName;
            LastName = LastName;
        }

        #region Methods
        public string CountPerson()
        {
            try
            {
                using (var db = new AccelaEntities())
                {
                    var count = db.PersonModels
                    .Count();
                    return count.ToString();
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }

        public bool AddPerson(string firstName, string lastName)
        {
            try
            {
                using(var db = new AccelaEntities())
                {
                    var person = new PersonModel { FIRST_NAME = firstName, LAST_NAME = lastName };
                    db.PersonModels.Add(person);
                    db.SaveChanges();
                    MessageBox.Show("Person has been added to the database.");
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }

        public bool AddPersonXML(string xmlPath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);

                XmlNode firstNameNode = doc.DocumentElement.SelectSingleNode("FirstName");
                string firstName = firstNameNode.InnerText;
                XmlNode lastNameNode = doc.DocumentElement.SelectSingleNode("LastName");
                string lastName = lastNameNode.InnerText;

                using (var db = new AccelaEntities())
                {
                    var person = new PersonModel { FIRST_NAME = firstName, LAST_NAME = lastName };
                    db.PersonModels.Add(person);
                    db.SaveChanges();
                    MessageBox.Show("Person has been added to the database through XML.");
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public bool EditPerson(int personId, string firstName, string lastName)
        {
            try
            {
                using (var db = new AccelaEntities())
                {
                    var result = db.PersonModels.SingleOrDefault(b => b.PERSON_ID == personId);
                    if (result != null)
                    {
                        if(!firstName.Equals(""))
                        {
                            result.FIRST_NAME = firstName;
                        }
                        if (!lastName.Equals(""))
                        {
                            result.LAST_NAME = lastName;
                        }
                        db.SaveChanges();
                        MessageBox.Show("This record has been edited sucessfully");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No value exists for the ID entered");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public void DeletePerson(string personId)
        {
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-D0FE3HM;Initial Catalog=Accela;Integrated Security=True"))
                {
                    connection.Open();
                    var sql = "DELETE FROM TBL_ADDRESS WHERE PERSON_ID = @PersonId";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonId", personId);

                        cmd.ExecuteNonQuery();
                    }

                    sql = "DELETE FROM TBL_PERSON WHERE PERSON_ID = @PersonId";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonId", personId);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("This person and all of their related addresses have been deleted.");
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        public List<PersonModel> ListPersons()
        {
            try
            {
                using(var db = new AccelaEntities())
                {
                    var people = db.PersonModels;
                    return people.ToList();

                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }
        #endregion
    }

    class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }


        public Address()
        {
            Id = Id;
            Street = Street;
            City = City;
            State = State;
            Postcode = Postcode;
        }

        #region Methods

        public bool AddAddress(string personId, string street, string city, string state, string postalCode)
        {
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-D0FE3HM;Initial Catalog=Accela;Integrated Security=True"))
                {
                    connection.Open();
                    var sql = "INSERT INTO TBL_ADDRESS(PERSON_ID, STREET, CITY, STATE, POSTAL_CODE) VALUES(@PersonId, @Street, @City, @State, @PostalCode)";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonId", personId);
                        cmd.Parameters.AddWithValue("@Street", street);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@PostalCode", postalCode);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("This address has been added.");
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }

        public void DeleteAddress(string addressId)
        {
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-D0FE3HM;Initial Catalog=Accela;Integrated Security=True"))
                {
                    connection.Open();
                    var sql = "DELETE FROM TBL_ADDRESS WHERE ADDRESS_ID = @AddressID";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@AddressID", addressId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("This address has been deleted.");
                    }
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }
        }

        public bool EditAddress(int addressId, string street, string city, string state, string postcode)
        {
            try
            {
                using (var db = new AccelaEntities())
                {
                    var result = db.AddressModels.SingleOrDefault(b => b.ADDRESS_ID == addressId);
                    if (result != null)
                    {
                        if (!street.Equals(""))
                        {
                            result.STREET = street;
                        }
                        if (!city.Equals(""))
                        {
                            result.CITY = city;
                        }
                        if (!state.Equals(""))
                        {
                            result.STATE = state;
                        }
                        if (!postcode.Equals(""))
                        {
                            result.POSTAL_CODE = postcode;
                        }
                        db.SaveChanges();
                        MessageBox.Show("This record has been edited sucessfully");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No value exists for the ID entered");
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
        #endregion
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonForm());
        }
    }
}
