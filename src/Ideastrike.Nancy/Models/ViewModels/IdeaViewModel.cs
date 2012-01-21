﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ideastrike.Nancy.Helpers;

namespace Ideastrike.Nancy.Models.ViewModels
{
    public class IdeaViewModel
    {
        public IdeaViewModel(Idea idea)
        {
            Id = idea.Id;
            Title = idea.Title;
            Description = MarkdownHelper.Markdown(idea.Description);

            TotalVotes = idea.Votes.Count;

            Features = idea.Features.Select(f => new FeatureViewModel(f)).ToList();
        }

        public IEnumerable<FeatureViewModel> Features { get; set; }
        
        public bool UserHasVoted { get; set; }
        public int TotalVotes { get; private set; }
        public string Title { get; private set; }
        public int Id { get; private set; }
        public IHtmlString Description { get; private set; }
    }
}