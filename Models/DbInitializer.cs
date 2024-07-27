using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace CarServiceProject.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            CarServiceDbContext context =
                applicationBuilder.ApplicationServices.CreateScope().
                ServiceProvider.GetRequiredService<CarServiceDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.InventoryItems.Any())
            {
                // Filters and Fluids
                context.AddRange(
                    new InventoryItem
                    {
                        Name = "Engine Oil Filter",
                        Description = "High-performance oil filter for efficient filtration",
                        Price = 15.99M,
                        DiscountedPrice = 14.00M,
                        OnSale = true,
                        Category = Categories["Filters and Fluids"],
                        ImageUrl = "images/inventory/FilterAndFluids/EngineOilFilter.png",
                    },
                    new InventoryItem
                    {
                        Name = "Synthetic Motor Oil",
                        Description = "Premium synthetic motor oil for extended engine life",
                        Price = 39.99M,
                        OnSale = false,
                        Category = Categories["Filters and Fluids"],
                        ImageUrl = "images/inventory/FilterAndFluids/SyntheticMotorOil.png",
                    },
                    new InventoryItem
                    {
                        Name = "Air Filter",
                        Description = "High-quality air filter for improved engine performance",
                        Price = 19.99M,
                        OnSale = false,
                        Category = Categories["Filters and Fluids"],
                        ImageUrl = "images/inventory/FilterAndFluids/AirFilter.png",
                    },
                    new InventoryItem
                    {
                        Name = "Cabin Air Filter",
                        Description = "Provides cleaner air for your car's interior",
                        Price = 24.99M,
                        OnSale = false,
                        Category = Categories["Filters and Fluids"],
                        ImageUrl = "images/inventory/FilterAndFluids/CabinAirFilter.png",
                    }
                );

                // Tires and Wheels
                context.AddRange(
                    new InventoryItem
                    {
                        Name = "All-Season Tires",
                        Description = "Durable tires for reliable traction in all weather conditions",
                        Price = 129.99M,
                        DiscountedPrice = 110.00M,
                        OnSale = true,
                        Category = Categories["Tires and Wheels"],
                        ImageUrl = "images/inventory/TiresAndWheels/AllSeasonTires.png"
                    },
                    new InventoryItem
                    {
                        Name = "Winter Tires",
                        Description = "Specialized tires for superior grip in snow and ice",
                        Price = 149.99M,
                        OnSale = false,
                        Category = Categories["Tires and Wheels"],
                        ImageUrl = "images/inventory/TiresAndWheels/WinterTires.png"
                    },
                    new InventoryItem
                    {
                        Name = "Alloy Wheels",
                        Description = "Stylish and lightweight alloy wheels for enhanced performance",
                        Price = 299.99M,
                        OnSale = false,
                        Category = Categories["Tires and Wheels"],
                        ImageUrl = "images/inventory/TiresAndWheels/AlloyWheels.png"
                    },
                    new InventoryItem
                    {
                        Name = "Steel Wheels",
                        Description = "Durable and affordable steel wheels for everyday driving",
                        Price = 79.99M,
                        OnSale = false,
                        Category = Categories["Tires and Wheels"],
                        ImageUrl = "images/inventory/TiresAndWheels/SteelWheels.png"
                    }
                );

                // Interior Parts
                context.AddRange(
                    new InventoryItem
                    {
                        Name = "Leather Steering Wheel Cover",
                        Description = "Stylish and comfortable steering wheel cover for a luxurious feel",
                        Price = 49.99M,
                        DiscountedPrice = 44.00M,
                        OnSale = true,
                        Category = Categories["Interior Parts"],
                        ImageUrl = "images/inventory/InteriorParts/LeatherSteeringWheelCover.png"
                    },
                    new InventoryItem
                    {
                        Name = "Floor Mats",
                        Description = "All-weather floor mats to protect your interior from dirt and spills",
                        Price = 29.99M,
                        OnSale = false,
                        Category = Categories["Interior Parts"],
                        ImageUrl = "images/inventory/InteriorParts/FloorMats.png"
                    },
                    new InventoryItem
                    {
                        Name = "Car Seat Covers",
                        Description = "Protect your car seats with stylish and comfortable covers",
                        Price = 79.99M,
                        OnSale = false,
                        Category = Categories["Interior Parts"],
                        ImageUrl = "images/inventory/InteriorParts/CarSeatCovers.png"
                    },
                    new InventoryItem
                    {
                        Name = "Phone Mount",
                        Description = "Convenient and secure phone mount for hands-free driving",
                        Price = 19.99M,
                        OnSale = false,
                        Category = Categories["Interior Parts"],
                        ImageUrl = "images/inventory/InteriorParts/PhoneMount.png"
                    }
                );

                context.SaveChanges();
            }

            if (!context.Employees.Any())
            {
                context.AddRange(
                    new Employee
                    {
                        Name = "John Smith",
                        ImageUrl = "images/employee/JohnSmith.png",
                        Position = "Master Mechanic",
                        ContactInfo = new ContactInfo
                        {
                            Email = "john.smith@carservice.com",
                            Phone = "(021) 555-1234"
                        }
                    },
                    new Employee
                    {
                        Name = "Jane Doe",
                        ImageUrl = "images/employee/JaneDoe.png",
                        Position = "Service Advisor",
                        ContactInfo = new ContactInfo
                        {
                            Email = "jane.doe@carservice.com",
                            Phone = "(021) 555-5678"
                        }
                    },
                    new Employee
                    {
                        Name = "Michael Lee",
                        ImageUrl = "images/employee/MichaelLee.png",
                        Position = "Mechanic",
                        ContactInfo = new ContactInfo
                        {
                            Email = "michael.lee@carservice.com",
                            Phone = "(021) 555-9012"
                        }
                    },
                    new Employee
                    {
                        Name = "Sarah Jones",
                        ImageUrl = "images/employee/SarahJones.png",
                        Position = "Customer Service Representative",
                        ContactInfo = new ContactInfo
                        {
                            Email = "sarah.jones@carservice.com",
                            Phone = "(021) 555-3456"
                        }
                    }
                );

                context.SaveChanges();
            }

            if (!context.Services.Any())
            {
                context.AddRange(
                    new Service
                    {
                        Name = "Diagnostic Tests",
                        Description = "Comprehensive computer-aided diagnostic testing to identify potential car problems.",
                        ImageUrl = "images/services/DiagnosticTest.jpg",
                        Price = 79.99M,
                        Duration = new TimeSpan(1, 0, 0) // 1 hour
                    },
                    new Service
                    {
                        Name = "Engine Servicing",
                        Description = "Complete engine servicing including oil change, filter replacements, and multi-point inspection.",
                        ImageUrl = "images/services/EngineServicing.jpg",
                        Price = 149.99M,
                        Duration = new TimeSpan(2, 0, 0)
                    },
                    new Service
                    {
                        Name = "Tires Replacement",
                        Description = "Professional replacement of all four tires, including balancing and alignment.",
                        ImageUrl = "images/services/TiresReplacement.jpg",
                        Price = 100.55M,
                        Duration = new TimeSpan(0, 15, 0)
                    },
                    new Service
                    {
                        Name = "Oil Changing",
                        Description = "Oil change with high-quality synthetic motor oil and filter replacement.",
                        ImageUrl = "images/services/TiresReplacement.jpg",
                        Price = 49.99M,
                        Duration = new TimeSpan(0, 45, 0)
                    }
                );

                context.SaveChanges();
            }

            if(!context.CustomerFeedbacks.Any()){
                context.AddRange(
                    new CustomerFeedback
                    {
                        Name = "John Doe",
                        ImageUrl = "images/customers/JohnDoe.png",
                        Comments = "Great service! The mechanics were professional and explained everything clearly. They were also able to fix my car quickly and efficiently.",
                        Rating = 5
                    },
                    new CustomerFeedback
                    {
                        Name = "Jane Smith",
                        ImageUrl = "images/customers/JaneSmith.png",
                        Comments = "Very happy with the service I received. The staff was friendly and helpful, and they were able to get my car back to me in a timely manner.",
                        Rating = 4
                    },
                    new CustomerFeedback
                    {
                        Name = "Michael Jones",
                        ImageUrl = "images/customers/MichaelJones.png",
                        Comments = "I would definitely recommend this car service to my friends and family. The prices are fair, and the quality of work is excellent.",
                        Rating = 5
                    },
                    new CustomerFeedback
                    {
                        Name = "Sarah Lee",
                        ImageUrl = "images/customers/SarahLee.png",
                        Comments = "The service was good, but it took a little longer than expected to complete the repairs.",
                        Rating = 4
                    },
                    new CustomerFeedback
                    {
                        Name = "David Williams",
                        ImageUrl = "images/customers/DavidWilliams.png",
                        Comments = "Overall, I was satisfied with the service. The mechanics were knowledgeable and did a good job.",
                        Rating = 3
                    },
                    new CustomerFeedback
                    {
                        Name = "Emily Brown",
                        ImageUrl = "images/customers/EmilyBrown.png",
                        Comments = "The car service was a bit expensive, but the work was done well.",
                        Rating = 4
                    },
                    new CustomerFeedback
                    {
                        Name = "Robert Thompson",
                        ImageUrl = "images/customers/RobertThompson.png",
                        Comments = "I was disappointed with the communication from the service department. It was difficult to get updates on the progress of my repairs.",
                        Rating = 2
                    }
                );

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category>? categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var itemCategoryList = new Category[]
                    {
                        new Category { Name = "Filters and Fluids" },
                        new Category { Name = "Tires and Wheels" },
                        new Category { Name = "Interior Parts" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category itemCategory in itemCategoryList)
                    {
                        categories.Add(itemCategory.Name, itemCategory);
                    }
                }

                return categories;
            }
        }
    }


}