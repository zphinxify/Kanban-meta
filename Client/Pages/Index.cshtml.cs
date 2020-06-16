using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Client.Models;
using Client.Data;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        KanbanRepository repo;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            //repo.GetColumns();
        }
        
        public void OnPost(string description){
            var newCard = new Card();
            newCard.Name = description;
            newCard.Description = "Majs";
            newCard.IsCompleted = false;
            //repo.AddCard(newCard);
        }
        public void OnDelete(int ID)
        {
            //repo.RemoveCard(ID);
        }
        public void OnPut(int ID, string name)
        {
            var updateCard = new Card();
            updateCard.ID = ID;
            updateCard.Name = name;
            updateCard.IsCompleted = false;
            //repo.UpdateCard(updateCard);
        }
    }
}
