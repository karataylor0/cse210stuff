using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Events Marketing Material:\n");

        Address address1 = new Address("123 Road Street","Chicago", "Illinois", "United States of America", 84629);
        Lecture lecture1 = new Lecture("Carving Your Way into the Future", "Join us as Marvin McGarvin explains the important role that woodworking will play into future developments, such as wooden spaceships, stick teleportion, and birch aliens.","October 30th, 2025", "3:00pm", address1.StringAddress(), "Marvin McGarvin", 32);
        lecture1.StandardDetails();
        Console.Write("\n");
        lecture1.FullDetails();

        Address address2 = new Address("289 S 100 W", "Salt Lake City", "North Dakota", "Ireland", 73619);
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("cloudy with a chance of meatballs", "Volleyball Tournament", "Join us for a fun day of sun, snacks, and volleyball! Battle it out against other teams to the champion!","Tuesday","10am to 5pm", address2.StringAddress());
        Console.Write("\n");
        outdoorGathering1.StandardDetails();
        Console.Write("\n");
        outdoorGathering1.FullDetails();

        Address address3 = new Address("479 Banana Lane", "Toronto", "New Mexico", "Antartica", 87371);
        Reception reception1 = new Reception("receptionsandwhatnot@gmail.com", "Jill Jacobson and Josh Johnson's Wedding Reception","Join us in celebrating Jill and Josh being married.", "All day, every day", "forever", address3.StringAddress());
        Console.Write("\n");
        reception1.StandardDetails();
        Console.Write("\n");
        reception1.FullDetails();

        Address address4 = new Address("123 Road Street", "New York City", "New York", "USA", 12345);
        BirthdayParty birthdayParty1 = new BirthdayParty(15, "cake and ice cream", "Anna's 5th Birthday", "Join us for celebrating Anna's birthday!", "July 5th", "10am -12", address4.StringAddress());
        Console.Write("\n");
        birthdayParty1.StandardDetails();
        Console.Write("\n");
        birthdayParty1.FullDetails();
    }
}