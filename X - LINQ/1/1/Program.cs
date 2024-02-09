using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; } = string.Empty; // Initialized as non-null
    public string LastName { get; set; } = string.Empty;  // Initialized as non-null
    public int Age { get; set; }
    public int RoleId { get; set; }
}

public class Role
{
    public int RoleId { get; set; }
    public string RoleDescription { get; set; } = string.Empty; // Initialized as non-null
}
public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public string Category { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
}

public class OrderDetails
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        // Existing code to interact with the array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };
        bool continueProgram = true;

        while (continueProgram)
        {
            try
            {
                Console.WriteLine("Enter the index of the element you want to see (0-4):");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The element at index {index} is: {numbers[index]}");
                Console.WriteLine("Do you want to see another number? (yes/no)");
                continueProgram = Console.ReadLine().ToLower() == "yes";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array. Please try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        // Initialize and populate lists for Person and Role
        List<Person> people = new List<Person>(); // Populate this list
        List<Role> roles = new List<Role>(); // Populate this list

        // LINQ operations for the Person and Role lists
        // (Add your LINQ operations here)

        // Initialize and populate lists for Product, Customer, Order, and OrderDetails
        List<Product> products = new List<Product>(); // Populate this list
        List<Customer> customers = new List<Customer>(); // Populate this list
        List<Order> orders = new List<Order>(); // Populate this list
        List<OrderDetails> orderDetails = new List<OrderDetails>(); // Populate this list

        // LINQ operations for the Product, Customer, Order, and OrderDetails lists
        // (Add your LINQ operations here)
    }
}

