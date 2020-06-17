﻿using System;
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
        private KanbanRepository _repo;
        private readonly ILogger<IndexModel> _logger;
        public List<Card> Cards { get; set; } = new List<Card>();

        public IndexModel(ILogger<IndexModel> logger, KanbanRepository repository)
        {
            _logger = logger;
            _repo = repository;
        }
        public void OnGet()
        {
            //cards = _repo.GetColumns();
        }
        
        public void OnPost(string description){
            var newCard = new Card();
            newCard.Name = description;
            newCard.ColumnID = 1;
            newCard.IsCompleted = false;
            _repo.AddCard(newCard);
        }
        public void OnDelete(int ID)
        {
            _repo.RemoveCard(ID);
        }
        public void OnPut(int ID, string name)
        {
            var updateCard = new Card();
            updateCard.ID += ID;
            updateCard.Name = name;
            updateCard.IsCompleted = false;
            _repo.UpdateCard(updateCard);
        }
    }
}
