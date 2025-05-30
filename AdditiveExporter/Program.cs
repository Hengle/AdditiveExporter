﻿using AdditiveExporter.Utils;

using Constants = AdditiveExporter.Utils.Constants;

namespace AdditiveExporter
{
    public class Progam
    {
        static async Task Main(string[] args)
        {
            if(!Directory.Exists(Constants.DataPath))
                Directory.CreateDirectory(Constants.DataPath);

            if (!Directory.Exists(Constants.ExportPath))
                Directory.CreateDirectory(Constants.ExportPath);

            Console.Title = "Additive Animation Exporter by Zylox";
            
            Console.Clear();

            await FileProvider.Init();

            while (true)
            {
                FileProvider.ExportAdditiveAnimation();
                Console.WriteLine();
            }
        }
    }
}