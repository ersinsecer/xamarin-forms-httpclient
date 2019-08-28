using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XForms.Models;

namespace XForms.Services
{
    public class Ssrvices
    {
        HttpClient client = new HttpClient();
        public async Task<List<Author>> GetAuthorListAsync()
        {
            var response = await client.GetStringAsync("http://192.168.1.3:45455/api/author");
            var authorList = JsonConvert.DeserializeObject<List<Author>>(response);
            return authorList;
        }

        public async Task<List<Book>> GetBookListAsync()
        {
            var response = await client.GetStringAsync("http://192.168.1.3:45455/api/book");
            var bookList = JsonConvert.DeserializeObject<List<Book>>(response);
            return bookList;
        }

        public async Task<int> AddBook(Book book)
        {
            var data = JsonConvert.SerializeObject(book);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://192.168.1.3:45455/api/book", content);
            var result = JsonConvert.DeserializeObject<int>(response.Content.ReadAsStringAsync().Result);
            return result;
        }
    }
}
