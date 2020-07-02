﻿using System.Threading.Tasks;

namespace Photos.Shared.Services
{
    public interface ITwilioService
    {
        Task<string> PurchasePhoneNumber(string phoneNumber);
        Task<string> SearchPhoneNumber(string areaCode);
    }
}
