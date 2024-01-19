
using System.Dynamic;
using System.Numerics;
using System.Runtime.CompilerServices;

class Student
{
    protected static int ID { get; set; }
    public string name;
    public string email;
    public string phoneNumber { get; set; }
    public string dob;
    public int generateId()
    {
        return ID++;
    }
    public string GetName()
    {
        return this.name;
    }
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetEmail(string name)
    {
        string emailAddress = name;
        int len = name.Length;

        int i = 1;
        while (emailAddress.Contains(" ") && i < len)
        {
            emailAddress = emailAddress.Remove(i, emailAddress.IndexOf(" ") - i + 1);
            i++;
        }

        this.email = emailAddress.ToLower() + "." + this.dob.Replace("/", "") + "@hcmut.edu.vn";
    }
    public string GetEmail()
    {
        return this.email;
    }
    public void SetDOB(DateTime dob)
    {
        this.dob = dob.ToShortDateString();
    }
    public string GetDOB()
    {
        return this.dob;
    }
}