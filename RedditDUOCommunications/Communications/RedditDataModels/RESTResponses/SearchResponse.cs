using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public class SearchResponse
    {
        public class Facets
        {
        }

        public class MediaEmbed
        {
            public string content { get; set; }
            public int width { get; set; }
            public bool scrolling { get; set; }
            public int height { get; set; }
        }

        public class Oembed
        {
            public string provider_url { get; set; }
            public string description { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string type { get; set; }
            public int thumbnail_width { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string html { get; set; }
            public string version { get; set; }
            public string provider_name { get; set; }
            public string thumbnail_url { get; set; }
            public int thumbnail_height { get; set; }
            public string author_name { get; set; }
            public string author_url { get; set; }
        }

        public class RedditVideo
        {
            public string fallback_url { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string scrubber_media_url { get; set; }
            public string dash_url { get; set; }
            public int duration { get; set; }
            public string hls_url { get; set; }
            public bool is_gif { get; set; }
            public string transcoding_status { get; set; }
        }

        public class SecureMedia
        {
            public string type { get; set; }
            public Oembed oembed { get; set; }
            public RedditVideo reddit_video { get; set; }
        }

        public class SecureMediaEmbed
        {
            public string content { get; set; }
            public int width { get; set; }
            public bool scrolling { get; set; }
            public string media_domain_url { get; set; }
            public int height { get; set; }
        }

        public class Gildings
        {
            public int gid_1 { get; set; }
            public int gid_2 { get; set; }
        }

        public class Source
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Resolution
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Source2
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Resolution2
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Gif
        {
            public Source2 source { get; set; }
            public List<Resolution2> resolutions { get; set; }
        }

        public class Source3
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Resolution3
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Mp4
        {
            public Source3 source { get; set; }
            public List<Resolution3> resolutions { get; set; }
        }

        public class Variants
        {
            public Gif gif { get; set; }
            public Mp4 mp4 { get; set; }
        }

        public class Image
        {
            public Source source { get; set; }
            public List<Resolution> resolutions { get; set; }
            public Variants variants { get; set; }
            public string id { get; set; }
        }

        public class Preview
        {
            public List<Image> images { get; set; }
            public bool enabled { get; set; }
        }

        public class Oembed2
        {
            public string provider_url { get; set; }
            public string description { get; set; }
            public string title { get; set; }
            public string url { get; set; }
            public string type { get; set; }
            public int thumbnail_width { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string html { get; set; }
            public string version { get; set; }
            public string provider_name { get; set; }
            public string thumbnail_url { get; set; }
            public int thumbnail_height { get; set; }
            public string author_name { get; set; }
            public string author_url { get; set; }
        }

        public class RedditVideo2
        {
            public string fallback_url { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public string scrubber_media_url { get; set; }
            public string dash_url { get; set; }
            public int duration { get; set; }
            public string hls_url { get; set; }
            public bool is_gif { get; set; }
            public string transcoding_status { get; set; }
        }

        public class Media
        {
            public string type { get; set; }
            public Oembed2 oembed { get; set; }
            public RedditVideo2 reddit_video { get; set; }
        }

        public class MediaEmbed2
        {
        }

        public class SecureMediaEmbed2
        {
        }

        public class Gildings2
        {
        }

        public class Source4
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Resolution4
        {
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Variants2
        {
        }

        public class Image2
        {
            public Source4 source { get; set; }
            public List<Resolution4> resolutions { get; set; }
            public Variants2 variants { get; set; }
            public string id { get; set; }
        }

        public class Preview2
        {
            public List<Image2> images { get; set; }
            public bool enabled { get; set; }
        }

        public class CrosspostParentList
        {
            public object approved_at_utc { get; set; }
            public string subreddit { get; set; }
            public string selftext { get; set; }
            public string author_fullname { get; set; }
            public bool saved { get; set; }
            public object mod_reason_title { get; set; }
            public int gilded { get; set; }
            public bool clicked { get; set; }
            public string title { get; set; }
            public List<object> link_flair_richtext { get; set; }
            public string subreddit_name_prefixed { get; set; }
            public bool hidden { get; set; }
            public object pwls { get; set; }
            public string link_flair_css_class { get; set; }
            public int downs { get; set; }
            public int thumbnail_height { get; set; }
            public bool hide_score { get; set; }
            public string name { get; set; }
            public bool quarantine { get; set; }
            public string link_flair_text_color { get; set; }
            public object author_flair_background_color { get; set; }
            public string subreddit_type { get; set; }
            public int ups { get; set; }
            public int total_awards_received { get; set; }
            public MediaEmbed2 media_embed { get; set; }
            public int thumbnail_width { get; set; }
            public object author_flair_template_id { get; set; }
            public bool is_original_content { get; set; }
            public List<object> user_reports { get; set; }
            public object secure_media { get; set; }
            public bool is_reddit_media_domain { get; set; }
            public bool is_meta { get; set; }
            public object category { get; set; }
            public SecureMediaEmbed2 secure_media_embed { get; set; }
            public string link_flair_text { get; set; }
            public bool can_mod_post { get; set; }
            public int score { get; set; }
            public object approved_by { get; set; }
            public bool author_premium { get; set; }
            public string thumbnail { get; set; }
            public bool edited { get; set; }
            public object author_flair_css_class { get; set; }
            public List<object> steward_reports { get; set; }
            public List<object> author_flair_richtext { get; set; }
            public Gildings2 gildings { get; set; }
            public string post_hint { get; set; }
            public object content_categories { get; set; }
            public bool is_self { get; set; }
            public object mod_note { get; set; }
            public double created { get; set; }
            public string link_flair_type { get; set; }
            public object wls { get; set; }
            public object removed_by_category { get; set; }
            public object banned_by { get; set; }
            public string author_flair_type { get; set; }
            public string domain { get; set; }
            public bool allow_live_comments { get; set; }
            public object selftext_html { get; set; }
            public object likes { get; set; }
            public object suggested_sort { get; set; }
            public object banned_at_utc { get; set; }
            public object view_count { get; set; }
            public bool archived { get; set; }
            public bool no_follow { get; set; }
            public bool is_crosspostable { get; set; }
            public bool pinned { get; set; }
            public bool over_18 { get; set; }
            public Preview2 preview { get; set; }
            public List<object> all_awardings { get; set; }
            public List<object> awarders { get; set; }
            public bool media_only { get; set; }
            public string link_flair_template_id { get; set; }
            public bool can_gild { get; set; }
            public bool spoiler { get; set; }
            public bool locked { get; set; }
            public object author_flair_text { get; set; }
            public bool visited { get; set; }
            public object removed_by { get; set; }
            public object num_reports { get; set; }
            public object distinguished { get; set; }
            public string subreddit_id { get; set; }
            public object mod_reason_by { get; set; }
            public object removal_reason { get; set; }
            public string link_flair_background_color { get; set; }
            public string id { get; set; }
            public bool is_robot_indexable { get; set; }
            public object report_reasons { get; set; }
            public string author { get; set; }
            public object discussion_type { get; set; }
            public int num_comments { get; set; }
            public bool send_replies { get; set; }
            public object whitelist_status { get; set; }
            public bool contest_mode { get; set; }
            public List<object> mod_reports { get; set; }
            public bool author_patreon_flair { get; set; }
            public object author_flair_text_color { get; set; }
            public string permalink { get; set; }
            public object parent_whitelist_status { get; set; }
            public bool stickied { get; set; }
            public string url { get; set; }
            public int subreddit_subscribers { get; set; }
            public double created_utc { get; set; }
            public int num_crossposts { get; set; }
            public object media { get; set; }
            public bool is_video { get; set; }
        }

        public class Data2
        {
            public object approved_at_utc { get; set; }
            public string subreddit { get; set; }
            public string selftext { get; set; }
            public string author_fullname { get; set; }
            public bool saved { get; set; }
            public object mod_reason_title { get; set; }
            public int gilded { get; set; }
            public bool clicked { get; set; }
            public string title { get; set; }
            public List<object> link_flair_richtext { get; set; }
            public string subreddit_name_prefixed { get; set; }
            public bool hidden { get; set; }
            public int? pwls { get; set; }
            public string link_flair_css_class { get; set; }
            public int downs { get; set; }
            public int? thumbnail_height { get; set; }
            public bool hide_score { get; set; }
            public string name { get; set; }
            public bool quarantine { get; set; }
            public string link_flair_text_color { get; set; }
            public string author_flair_background_color { get; set; }
            public string subreddit_type { get; set; }
            public int ups { get; set; }
            public int total_awards_received { get; set; }
            public MediaEmbed media_embed { get; set; }
            public int? thumbnail_width { get; set; }
            public string author_flair_template_id { get; set; }
            public bool is_original_content { get; set; }
            public List<object> user_reports { get; set; }
            public SecureMedia secure_media { get; set; }
            public bool is_reddit_media_domain { get; set; }
            public bool is_meta { get; set; }
            public object category { get; set; }
            public SecureMediaEmbed secure_media_embed { get; set; }
            public string link_flair_text { get; set; }
            public bool can_mod_post { get; set; }
            public int score { get; set; }
            public object approved_by { get; set; }
            public bool author_premium { get; set; }
            public string thumbnail { get; set; }
            public object edited { get; set; }
            public string author_flair_css_class { get; set; }
            public List<object> steward_reports { get; set; }
            public List<object> author_flair_richtext { get; set; }
            public Gildings gildings { get; set; }
            public string post_hint { get; set; }
            public object content_categories { get; set; }
            public bool is_self { get; set; }
            public object mod_note { get; set; }
            public double created { get; set; }
            public string link_flair_type { get; set; }
            public int? wls { get; set; }
            public object removed_by_category { get; set; }
            public object banned_by { get; set; }
            public string author_flair_type { get; set; }
            public string domain { get; set; }
            public bool allow_live_comments { get; set; }
            public string selftext_html { get; set; }
            public object likes { get; set; }
            public object suggested_sort { get; set; }
            public object banned_at_utc { get; set; }
            public object view_count { get; set; }
            public bool archived { get; set; }
            public bool no_follow { get; set; }
            public bool is_crosspostable { get; set; }
            public bool pinned { get; set; }
            public bool over_18 { get; set; }
            public Preview preview { get; set; }
            public List<object> all_awardings { get; set; }
            public List<object> awarders { get; set; }
            public bool media_only { get; set; }
            public bool can_gild { get; set; }
            public bool spoiler { get; set; }
            public bool locked { get; set; }
            public string author_flair_text { get; set; }
            public bool visited { get; set; }
            public object removed_by { get; set; }
            public object num_reports { get; set; }
            public object distinguished { get; set; }
            public string subreddit_id { get; set; }
            public object mod_reason_by { get; set; }
            public object removal_reason { get; set; }
            public string link_flair_background_color { get; set; }
            public string id { get; set; }
            public bool is_robot_indexable { get; set; }
            public object report_reasons { get; set; }
            public string author { get; set; }
            public object discussion_type { get; set; }
            public int num_comments { get; set; }
            public bool send_replies { get; set; }
            public string whitelist_status { get; set; }
            public bool contest_mode { get; set; }
            public List<object> mod_reports { get; set; }
            public bool author_patreon_flair { get; set; }
            public string author_flair_text_color { get; set; }
            public string permalink { get; set; }
            public string parent_whitelist_status { get; set; }
            public bool stickied { get; set; }
            public string url { get; set; }
            public int subreddit_subscribers { get; set; }
            public double created_utc { get; set; }
            public int num_crossposts { get; set; }
            public Media media { get; set; }
            public bool is_video { get; set; }
            public string link_flair_template_id { get; set; }
            public List<CrosspostParentList> crosspost_parent_list { get; set; }
            public string crosspost_parent { get; set; }
        }

        public class Child
        {
            public string kind { get; set; }
            public Data2 data { get; set; }
        }

        public class Data
        {
            public string after { get; set; }
            public int dist { get; set; }
            public Facets facets { get; set; }
            public string modhash { get; set; }
            public List<Child> children { get; set; }
            public object before { get; set; }
        }

        public string kind { get; set; }
        public Data data { get; set; }
    }
}
