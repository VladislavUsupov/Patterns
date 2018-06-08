using System;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    public class SubscriberViewer
    {
        public Dictionary<SocialNetwork, ISocialNetworkStrategy> dictionary;

        /// <summary>
        /// Возвращает список подписчиков пользователя из соц.сети.
        /// TODO: необходимо изменить этот метод по условиям задачи
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>
        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
            return dictionary[networkType].GetSubscribers();
        }
    }
}