using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takrorlash_oop.Model
{
    public class ShortenedLink
    {
        public int Id {  get; set; }    
        public string OriginalUrl { get; set; }
        public string ShortenedUrl { get; set; }

        public ShortenedLink(int id, string orginalUrl, string shortenedUrl)
        {
            Id = id;
            OriginalUrl = orginalUrl;
            ShortenedUrl = shortenedUrl;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ShortenedLink url)
                return this.GetHashCode() == url.GetHashCode();
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + Id.GetHashCode();
            hash = hash * 23 + OriginalUrl.GetHashCode();
            hash = hash * 23 + ShortenedUrl.GetHashCode();
            return hash;    
        }

        public static bool operator == (ShortenedLink url1, ShortenedLink url2)
        {
            return url1.Equals(url2);
        }

        public static bool operator !=(ShortenedLink url1, ShortenedLink url2)
        {
            return !url1.Equals(url2);
        }

    }
}
