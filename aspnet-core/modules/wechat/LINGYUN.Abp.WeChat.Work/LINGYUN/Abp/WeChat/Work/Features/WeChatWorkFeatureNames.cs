﻿namespace LINGYUN.Abp.WeChat.Work.Features;

public static class WeChatWorkFeatureNames
{
    public const string GroupName = "WeChat.Work";
    /// <summary>
    /// 启用企业微信
    /// </summary>
    public const string Enable = GroupName + ".Enable";

    public static class Message
    {
        public const string GroupName = WeChatWorkFeatureNames.GroupName + ".Message";
        /// <summary>
        /// 启用消息推送
        /// </summary>
        public const string Enable = GroupName + ".Enable";
        /// <summary>
        /// 发送次数上限
        /// </summary>
        public const string SendLimit = GroupName + ".SendLimit";
        /// <summary>
        /// 发送次数上限时长
        /// </summary>
        public const string SendLimitInterval = GroupName + ".SendLimitInterval";
    }
}
