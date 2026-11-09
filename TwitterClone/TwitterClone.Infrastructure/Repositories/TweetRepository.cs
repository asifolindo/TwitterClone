using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Infrastructure.Repositories
{
    public class TweetRepository : ITweetRepository
    {
        private  List<Tweet> _tweets { get; set; }

        public TweetRepository()
        {
            _tweets = new List<Tweet>();
        }

        public Tweet AddTweet(Tweet tweet)
        {
            _tweets.Add(tweet);
            return tweet;
        }

        public bool DeleteTweet(Tweet id)
        {
            return _tweets.Remove(id);
        }

        public Tweet? GetTweetById(Guid id)
        {
            return _tweets.SingleOrDefault(t => t.Id == id);
        }

        public List<Tweet> GetTweets()
        {
            return _tweets;
        }

        public List<Tweet> GetTweetsByUserId(Guid userId)
        {
           return _tweets.Where(t => t.UserId == userId).ToList();
        }

        public Tweet UpdateTweet(Tweet tweet)
        {
            _tweets.RemoveAll(t => t.Id == tweet.Id);
            _tweets.Add(tweet);
            return tweet;
        }
    }
}
