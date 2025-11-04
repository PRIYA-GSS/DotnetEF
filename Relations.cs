// //One to One
// public class User
// {
//     public int Id { get; set; }
//     public string Username { get; set; }

//     public UserProfile Profile { get; set; }
// }

// public class UserProfile
// {
//     public int Id { get; set; }
//     public string Bio { get; set; }

//     public int UserId { get; set; }
//     public User User { get; set; }
// }
// //One to Many
// public class Category
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     // Navigation property
//     public List<Product> Products { get; set; }
// }

// public class Product
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     // Foreign key
//     public int CategoryId { get; set; }

//     // Navigation property
//     public Category Category { get; set; }
// }

// //Many to Many
// public class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public List<Course> Courses { get; set; }
// }

// public class Course
// {
//     public int Id { get; set; }
//     public string Title { get; set; }

//     public List<Student> Students { get; set; }
// }