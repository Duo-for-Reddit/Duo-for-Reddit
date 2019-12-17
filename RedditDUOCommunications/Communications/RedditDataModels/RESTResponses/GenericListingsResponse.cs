using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedditCommunications
{
    public abstract class GenericListingsResponse
    {
        [JsonObject(MemberSerialization.OptIn)]
        public class MediaEmbed
        {
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class SecureMediaEmbed
        {
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Gildings
        {
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Source
        {
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("width")]
            public int Width { get; set; }
            [JsonProperty("height")]
            public int Height { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Resolution
        {
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("width")]
            public int Width { get; set; }
            [JsonProperty("height")]
            public int Height { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Variants
        {
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Image
        {
            [JsonProperty("source")]
            public Source Source { get; set; }
            [JsonProperty("resolutions")]
            public List<Resolution> Resolutions { get; set; }
            [JsonProperty("variants")]
            public Variants Variants { get; set; }
            [JsonProperty("id")]
            public string Id { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Preview
        {
            [JsonProperty("images")]
            public List<Image> Images { get; set; }
            [JsonProperty("enabled")]
            public bool Enabled { get; set; }
        }

        // TODO: Rename class to something more descriptive.
        [JsonObject(MemberSerialization.OptIn)]
        public class Data2
        {
            // TODO: Replace "object" with its own class
            [JsonProperty("approved_at_utc")]
            public object ApprovedAtUtc { get; set; }
            [JsonProperty("subreddit")]
            public string Subreddit { get; set; }
            [JsonProperty("selftext")]
            public string Selftext { get; set; }
            [JsonProperty("author_fullname")]
            public string AuthorFullname { get; set; }
            [JsonProperty("saved")]
            public bool Saved { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("mod_reason_title")]
            public object ModReasonTitle { get; set; }
            [JsonProperty("gilded")]
            public int Gilded { get; set; }
            [JsonProperty("clicked")]
            public bool Clicked { get; set; }
            [JsonProperty("title")]
            public string Title { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("link_flair_richtext")]
            public List<object> LinkFlairRichtext { get; set; }
            [JsonProperty("subreddit_name_prefixed")]
            public string SubredditNamePrefixed { get; set; }
            [JsonProperty("hidden")]
            public bool Hidden { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("pwls")]
            public object Pwls { get; set; }
            public string link_flair_css_class { get; set; }
            [JsonProperty("downs")]
            public int Downs { get; set; }
            [JsonProperty("thumbnail_height")]
            public int? ThumbnailHeight { get; set; }
            [JsonProperty("hide_score")]
            public bool HideScore { get; set; }
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("quarantine")]
            public bool Quarantine { get; set; }
            [JsonProperty("link_flair_text_color")]
            public string LinkFlairTextColor { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("author_flair_background_color")]
            public object AuthorFlairBackgroundColor { get; set; }
            [JsonProperty("subreddit_type")]
            public string SubredditType { get; set; }
            [JsonProperty("ups")]
            public int Ups { get; set; }
            [JsonProperty("total_awards_received")]
            public int TotalAwardsReceived { get; set; }
            [JsonProperty("media_embed")]
            public MediaEmbed MediaEmbed { get; set; }
            [JsonProperty("thumbnail_width")]
            public int? ThumbnailWidth { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("author_flair_template_id")]
            public object AuthorFlairTemplateId { get; set; }
            [JsonProperty("is_original_content")]
            public bool IsOriginalContent { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("user_reports")]
            public List<object> UserReports { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("secure_media")]
            public object SecureMedia { get; set; }
            [JsonProperty("is_reddit_media_domain")]
            public bool IsRedditMediaDomain { get; set; }
            [JsonProperty("is_meta")]
            public bool IsMeta { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("category")]
            public object Category { get; set; }
            [JsonProperty("secure_media_embed")]
            public SecureMediaEmbed SecureMediaEmbed { get; set; }
            [JsonProperty("link_flair_text")]
            public string LinkFlairText { get; set; }
            [JsonProperty("can_mod_post")]
            public bool CanModPost { get; set; }
            [JsonProperty("score")]
            public int Score { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("approved_by")]
            public object ApprovedBy { get; set; }
            [JsonProperty("author_premium")]
            public bool AuthorPremium { get; set; }
            [JsonProperty("thumbnail")]
            public string Thumbnail { get; set; }
            [JsonProperty("edited")]
            public bool Edited { get; set; }
            public object author_flair_css_class { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("steward_reports")]
            public List<object> StewardReports { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("author_flair_richtext")]
            public List<object> AuthorFlairRichtext { get; set; }
            [JsonProperty("gildings")]
            public Gildings Gildings { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("content_categories")]
            public object ContentCategories { get; set; }
            [JsonProperty("is_self")]
            public bool IsSelf { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("mod_note")]
            public object ModNote { get; set; }
            [JsonProperty("created")]
            public double Created { get; set; }
            [JsonProperty("link_flair_type")]
            public string LinkFlairType { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("wls")]
            public object Wls { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("removed_by_category")]
            public object RemovedByCategory { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("banned_by")]
            public object BannedBy { get; set; }
            [JsonProperty("author_flair_type")]
            public string AuthorFlairType { get; set; }
            [JsonProperty("domain")]
            public string Domain { get; set; }
            [JsonProperty("allow_live_comments")]
            public bool AllowLiveComments { get; set; }
            [JsonProperty("selftext_html")]
            public string SelftextHtml { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("likes")]
            public object Likes { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("suggested_sort")]
            public object SuggestedSort { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("banned_at_utc")]
            public object BannedAtUtc { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("view_count")]
            public object ViewCount { get; set; }
            [JsonProperty("archived")]
            public bool Archived { get; set; }
            [JsonProperty("no_follow")]
            public bool NoFollow { get; set; }
            [JsonProperty("is_crosspostable")]
            public bool IsCrosspostable { get; set; }
            [JsonProperty("pinned")]
            public bool Pinned { get; set; }
            [JsonProperty("over_18")]
            public bool Over18 { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("all_awardings")]
            public List<object> AllAwardings { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("awarders")]
            public List<object> Awarders { get; set; }
            [JsonProperty("media_only")]
            public bool MediaOnly { get; set; }
            [JsonProperty("can_gild")]
            public bool CanGild { get; set; }
            [JsonProperty("spoiler")]
            public bool Spoiler { get; set; }
            [JsonProperty("locked")]
            public bool Locked { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("author_flair_text")]
            public object AuthorFlairText { get; set; }
            [JsonProperty("visited")]
            public bool Visited { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("removed_by")]
            public object RemovedBy { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("num_reports")]
            public object NumReports { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("distinguished")]
            public object Distinguished { get; set; }
            [JsonProperty("subreddit_id")]
            public string SubredditId { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("mod_reason_by")]
            public object ModReasonBy { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("removal_reason")]
            public object RemovalReason { get; set; }
            [JsonProperty("link_flair_background_color")]
            public string LinkFlairBackgroundColor { get; set; }
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("is_robot_indexable")]
            public bool IsRobotIndexable { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("report_reasons")]
            public object ReportReasons { get; set; }
            [JsonProperty("author")]
            public string Author { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("discussion_type")]
            public object DiscussionType { get; set; }
            [JsonProperty("num_comments")]
            public int NumComments { get; set; }
            [JsonProperty("send_replies")]
            public bool SendReplies { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("whitelist_status")]
            public object WhitelistStatus { get; set; }
            [JsonProperty("contest_mode")]
            public bool ContestMode { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("mod_reports")]
            public List<object> ModReports { get; set; }
            [JsonProperty("author_patreon_flair")]
            public bool AuthorPatreonFlair { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("author_flair_text_color")]
            public object AuthorFlairTextColor { get; set; }
            [JsonProperty("permalink")]
            public string Permalink { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("parent_whitelist_status")]
            public object ParentWhitelistStatus { get; set; }
            [JsonProperty("stickied")]
            public bool Stickied { get; set; }
            [JsonProperty("url")]
            public string Url { get; set; }
            [JsonProperty("subreddit_subscribers")]
            public int SubredditSubscribers { get; set; }
            [JsonProperty("created_utc")]
            public double CreatedUtc { get; set; }
            [JsonProperty("num_crossposts")]
            public int NumCrossposts { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("media")]
            public object Media { get; set; }
            [JsonProperty("is_video")]
            public bool IsVideo { get; set; }
            [JsonProperty("post_hint")]
            public string PostHint { get; set; }
            [JsonProperty("preview")]
            public Preview Preview { get; set; }
            [JsonProperty("link_flair_template_id")]
            public string LinkFlairTemplateId { get; set; }
        }

        [JsonObject(MemberSerialization.OptIn)]
        public class Child
        {
            [JsonProperty("kind")]
            public string Kind { get; set; }
            [JsonProperty("data")]
            public Data2 Data { get; set; }
        }

        // TODO: Rename class to something more descriptive.
        [JsonObject(MemberSerialization.OptIn)]
        public class Data
        {
            [JsonProperty("modhash")]
            public string Modhash { get; set; }
            [JsonProperty("dist")]
            public int Dist { get; set; }
            [JsonProperty("children")]
            public List<Child> Children { get; set; }
            [JsonProperty("after")]
            public string After { get; set; }
            // TODO: Replace "object" with its own class
            [JsonProperty("before")]
            public object Before { get; set; }
        }

        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("data")]
        public Data MainData { get; set; }
    }
}
