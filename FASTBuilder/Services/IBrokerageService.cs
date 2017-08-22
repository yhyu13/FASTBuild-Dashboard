﻿using System;

namespace FastBuilder.Services
{
	internal interface IBrokerageService
    {
		string[] WorkerNames { get; }
		string BrokeragePath { get; set; }

		event EventHandler WorkerCountChanged;
    }
}
