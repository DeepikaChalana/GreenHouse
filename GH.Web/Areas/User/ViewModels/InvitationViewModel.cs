﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GH.Web.Areas.User.ViewModels
{
    public class InvitationViewModel
    {
        public string Id { get; set; }
        public FriendInNetworkInfo Sender { get; set; }
        //Vu
        public string NetworkName { get; set; }

        public string Relationship { get; set; }
        public bool IsEmergency { get; set; }
        public int Rate { get; set; }
        public string InviteId { get; set; }

    }
}