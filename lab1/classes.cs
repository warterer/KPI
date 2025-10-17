using System.Collections.Generic;

public class CarModel
{
    public int ModelId { get; set; } // PK
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal DailyRate { get; set; }

    public ICollection<Car> Cars { get; set; }
}

public class Location
{
    public int LocationId { get; set; } // PK
    public string Address { get; set; }
    public string City { get; set; }

    public ICollection<Car> Cars { get; set; }
}

public class Car
{
    public int CarId { get; set; } // PK
    public string LicensePlate { get; set; }
    public string Status { get; set; }
    public int ModelId { get; set; } // FK
    public int LocationId { get; set; } // FK
    
    public CarModel CarModel { get; set; }
    public Location Location { get; set; }
    public ICollection<Rental> Rentals { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; } // PK
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public ICollection<Rental> Rentals { get; set; }
}

public class Feature
{
    public int FeatureId { get; set; } // PK
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ICollection<Rental> Rentals { get; set; }
}

public class Rental
{
    public int RentalId { get; set; } // PK
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalCost { get; set; }
    public int CarId { get; set; } // FK
    public int CustomerId { get; set; } // FK
    
    public Customer Customer { get; set; }
    public Car Car { get; set; }
    public ICollection<Feature> Features { get; set; } 
}