﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagCloudContainer.Result;

namespace TagCloudContainer.Interfaces
{
    public interface IBoringWordsFilter
    {
        Result<IEnumerable<string>> FilterText(string text);

        Result<IEnumerable<string>> FilterWords(IEnumerable<string> text);
    }
}