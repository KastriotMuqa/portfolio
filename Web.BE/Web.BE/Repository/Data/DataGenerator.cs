using Microsoft.EntityFrameworkCore;
using Web.BE.Repository.Context;

namespace Web.BE.Repository.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Trainings.Any())
                {
                    return;
                }

                context.Trainings.AddRange(
                    new Model.Entities.Training
                    {
                        Description = @"Often, programmers fall in love with Python because of the increased productivity it provides. Since there is no compilation step, the edit-test-debug cycle is incredibly fast. Debugging Python programs is easy: a bug or bad input will never cause a segmentation fault. Instead, when the interpreter discovers an error, it raises an exception. When the program doesn't catch the exception, the interpreter prints a stack trace. A source level debugger allows inspection of local and global variables, evaluation of arbitrary expressions, setting breakpoints, stepping through the code a line at a time, and so on. The debugger is written in Python itself, testifying to Python's introspective power. On the other hand, often the quickest way to debug a program is to add a few print statements to the source: the fast edit-test-debug cycle makes this simple approach very effective.",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 1,
                        Issuer = "Ubt College",
                        Title = "Java Course",
                        Image = "https://blog.ndepend.com/wp-content/uploads/global-coding-standards-2-960x460.jpg"
                    },
                    new Model.Entities.Training
                    {
                        Description = @"Python is commonly used for developing websites and software, task automation, data analysis, and data visualization. Since it’s relatively easy to learn, Python has been adopted by many non-programmers such as accountants and scientists, for a variety of everyday tasks, like organizing finances.

“Writing programs is a very creative and rewarding activity,” says University of Michigan and Coursera instructor Charles R Severance in his book Python for Everybody. “You can write programs for many reasons, ranging from making your living to solving a difficult data analysis problem to having fun to helping someone else solve a problem.”",
                        IssuedDate = DateTime.Parse("2021-06-03"),
                        Id = 2,
                        Issuer = "ICK",
                        Title = "Cyber Unity",
                        Image = "https://i.insider.com/60144316a7c0c4001991dde6?width=1000&format=jpeg&auto=webp"
                    },
                    new Model.Entities.Training
                    {
                        Description = @"Python is a computer programming language often used to build websites and software, automate tasks, and conduct data analysis. Python is a general-purpose language, meaning it can be used to create a variety of different programs and isn’t specialized for any specific problems. This versatility, along with its beginner-friendliness, has made it one of the most-used programming languages today. A survey conducted by industry analyst firm RedMonk found that it was the second-most popular programming language among developers in 2021 [1].",
                        IssuedDate = DateTime.Parse("2022-02-01"),
                        Id = 3,
                        Issuer = "Datacamp",
                        Title = "Training:SQDeveloperL Path for",
                        Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTIYiNjBuJRO1zgT0k26tFsJmA5Crmiv-WQxw&usqp=CAU"
                    },
                   new Model.Entities.Training
                   {
                       Description = @"Java is a high-level, class-based, object-oriented programming language that is designed to have as few implementation dependencies as possible. It is a general-purpose programming language intended to let programmers write once, run anywhere (WORA),[17] meaning that compiled Java code can run on all platforms that support Java without the need to recompile.[18] Java applications are typically compiled to bytecode that can run on any Java virtual machine (JVM) regardless of the underlying computer architecture. The syntax of Java is similar to C and C++, but has fewer low-level facilities than either of them. The Java runtime provides dynamic capabilities (such as reflection and runtime code modification) that are typically not available in traditional compiled languages. As of 2019, Java was one of the most popular programming languages in use according to GitHub,[19][20] particularly for client–server web applications, with a reported 9 million developers.[21]",
                       IssuedDate = DateTime.Parse("2021-10-10"),
                       Id = 4,
                       Issuer = "Ubt College",
                       Title = "Java Course",
                       Image = "https://thumbs.dreamstime.com/b/desktop-source-code-technology-background-developer-programer-coding-programming-wallpaper-computer-language-virus-124935260.jpg"
                   },
                    new Model.Entities.Training
                    {
                        Description = "",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 5,
                        Issuer = "Ubt College",
                        Title = "Java Course",
                        Image= "https://www.parkersoftware.com/wp-content/uploads/2020/10/pankaj-patel-_SgRNwAVNKw-unsplash-scaled.jpg"
                    },
                    new Model.Entities.Training
                    {
                        Description = @"C# is a language for professional programming. C# (pronounced C sharp) is a programming language designed for building a wide range of enterprise applications that run on the .NET Framework. The goal of C# is to provide a simple, safe, modern, object-oriented, highperformance , robust and durable language for .NET development. Also it enables developers to build solutions for the broadest range of clients, including Web applications, Microsoft Windows Forms-based applications, and thin- and smart-client devices.
object oriented programming
Visual C# developers can leverage their existing C, C++ , Java skills and knowledge to be successful in the Microsoft .NET development environment. So many C, Java, and C++ development will move to C# to take advantage of .NET features. In cooperation with the .NET CLR (Common Language Runtime), it provides a language to use for ComponentOriented software, without forcing programmers to abandon their existing knowledge in C, C++, or COM code.",
                        IssuedDate = DateTime.Parse("2021-10-10"),
                        Id = 6,
                        Issuer = "Ubt College",
                        Title = "Java Course",
                        Image = "https://c8.alamy.com/comp/PF3NTN/desktop-source-code-and-technology-background-developer-or-programer-with-coding-and-programming-wallpaper-by-computer-language-and-source-code-com-PF3NTN.jpg"
                    }) ;

                context.SaveChanges();
            }
        }
    }
}
