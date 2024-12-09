using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    private static readonly HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        try
        {
            var usersResponse = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            Console.WriteLine("Users:\n" + usersResponse);

            int postId = 20 + 20;
            var postResponse = await client.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{postId}");
            Console.WriteLine($"\nPost {postId}:\n" + postResponse);

            var commentsResponse = await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments");
            Console.WriteLine("\nComments:\n" + commentsResponse);

            int commentId = 100 + 20;
            var commentResponse = await client.GetStringAsync($"https://jsonplaceholder.typicode.com/comments/{commentId}");
            Console.WriteLine($"\nComment {commentId}:\n" + commentResponse);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
