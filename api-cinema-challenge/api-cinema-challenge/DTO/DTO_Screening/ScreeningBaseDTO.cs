﻿using System.Net.NetworkInformation;

namespace api_cinema_challenge.DTO.DTO_Screening
{
    public class ScreeningBaseDTO
    {
        public string status { get; set; }

        public ScreeningDTO data { get; set; }

        public ScreeningBaseDTO(ScreeningDTO screening)
        {
            status = "success";
            data = screening;
        }
    }
}
