﻿#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

using AngleSharp.Dom;
using ArchiSteamFarm.Core;
using ArchiSteamFarm.Web.Responses;
using Chrxw.ASFEnhance.Localization;
using System.Text;
using static Chrxw.ASFEnhance.Utils;

namespace Chrxw.ASFEnhance.Profile
{
    internal static class HtmlParser
    {
        //解析个人资料
        internal static string? ParseProfilePage(HtmlDocumentResponse response)
        {
            if (response == null)
            {
                return null;
            }

            IElement? eleNickName = response.Content.SelectSingleNode("//div[@class='persona_name']/span[1]");
            string nickName = eleNickName?.TextContent ?? "";

            IElement? eleLevel = response.Content.SelectSingleNode("//div[@class='profile_header_badgeinfo_badge_area']//span[@class='friendPlayerLevelNum']");
            string strLevel = eleLevel?.TextContent ?? "0";

            IElement? eleOnline = response.Content.SelectSingleNode("//div[@class='profile_in_game_name']");
            bool online = eleOnline == null;

            IElement? eleBadgesCount = response.Content.SelectSingleNode("//a[contains(@href,'/badges/')]/span[last()]");
            string? strBadgesCount = eleBadgesCount?.TextContent.Replace(",", "");

            IElement? eleGamesCount = response.Content.SelectSingleNode("//a[contains(@href,'/games/')]/span[last()]");
            string? strGamesCount = eleGamesCount?.TextContent.Trim().Replace(",", "");

            IElement? eleScreenshotsCount = response.Content.SelectSingleNode("//a[contains(@href,'/screenshots/')]/span[last()]");
            string? strScreenshotsCount = eleScreenshotsCount?.TextContent.Replace(",", "");

            IElement? eleVideosCount = response.Content.SelectSingleNode("//a[contains(@href,'/videos/')]/span[last()]");
            string? strVideosCount = eleVideosCount?.TextContent.Replace(",", "");

            IElement? eleWorkshopCount = response.Content.SelectSingleNode("//a[contains(@href,'/myworkshopfiles/')]/span[last()]");
            string? strWorkshopCount = eleWorkshopCount?.TextContent.Replace(",", "");

            IElement? eleRecommendedCount = response.Content.SelectSingleNode("//a[contains(@href,'/recommended/')]/span[last()]");
            string? strRecommendedCount = eleRecommendedCount?.TextContent.Replace(",", "");

            IElement? eleGuideCount = response.Content.SelectSingleNode("//a[contains(@href,'section=guides')]/span[last()]");
            string? strGuideCount = eleGuideCount?.TextContent.Replace(",", "");

            IElement? eleImagesCount = response.Content.SelectSingleNode("//a[contains(@href,'/images/')]/span[last()]");
            string? strImagesCount = eleImagesCount?.TextContent.Replace(",", "");

            IElement? eleGroupsCount = response.Content.SelectSingleNode("//a[contains(@href,'/groups/')]/span[last()]");
            string? strGroupsCount = eleGroupsCount?.TextContent.Replace(",", "");

            IElement? eleFriendsCount = response.Content.SelectSingleNode("//a[contains(@href,'/friends/')]/span[last()]");
            string? strFriendsCount = eleFriendsCount?.TextContent.Replace(",", "");

            StringBuilder result = new(string.Format(CurrentCulture, Langs.ProfileHeader));

            result.AppendLine(string.Format(CurrentCulture, Langs.ProfileNickname, nickName));
            result.AppendLine(string.Format(CurrentCulture, Langs.ProfileState, online ? Langs.Online : Langs.Offline));

            if (uint.TryParse(strLevel, out uint level))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileLevel, level));
            }

            if (uint.TryParse(strBadgesCount, out uint badges))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileBadges, badges));
            }

            if (uint.TryParse(strGamesCount, out uint games))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileGames, games));
            }

            if (uint.TryParse(strScreenshotsCount, out uint screenshots))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileScreenshots, screenshots));
            }

            if (uint.TryParse(strVideosCount, out uint videos))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileVideos, videos));
            }

            if (uint.TryParse(strWorkshopCount, out uint workshops))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileWorkshop, workshops));
            }

            if (uint.TryParse(strRecommendedCount, out uint recommendeds))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileRecommended, recommendeds));
            }

            if (uint.TryParse(strGuideCount, out uint guides))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileGuide, guides));
            }

            if (uint.TryParse(strImagesCount, out uint images))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileImages, images));
            }

            if (uint.TryParse(strGroupsCount, out uint groups))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileGroups, groups));
            }

            if (uint.TryParse(strFriendsCount, out uint friends))
            {
                result.AppendLine(string.Format(CurrentCulture, Langs.ProfileFriends, friends));
            }

            return result.ToString();
        }
    }
}
