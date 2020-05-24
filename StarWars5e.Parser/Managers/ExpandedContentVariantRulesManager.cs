﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;
using StarWars5e.Parser.Globalization;
using StarWars5e.Parser.Parsers;

namespace StarWars5e.Parser.Managers
{
    public class ExpandedContentVariantRulesManager
    {
        private readonly CloudBlobContainer _cloudBlobContainer;
        private readonly ExpandedContentVariantRulesProcessor _expandedContentVariantRulesProcessor;
        private readonly List<string> _ecVariantRulesFileName = new List<string> { "ec_variantrules.txt" };
        private readonly IGlobalization _globalization;

        public ExpandedContentVariantRulesManager(CloudStorageAccount cloudStorageAccount, IGlobalization globalization)
        {
            _globalization = globalization;
            _expandedContentVariantRulesProcessor = new ExpandedContentVariantRulesProcessor();

            var cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
            _cloudBlobContainer = cloudBlobClient.GetContainerReference($"variant-rules-{_globalization.Language}");
        }

        public async Task Parse()
        {
            var rules = await _expandedContentVariantRulesProcessor.Process(_ecVariantRulesFileName, _globalization);
            await _cloudBlobContainer.CreateIfNotExistsAsync(BlobContainerPublicAccessType.Off, null, null);
            foreach (var variantRule in rules)
            {
                var json = JsonConvert.SerializeObject(variantRule);
                var blob = _cloudBlobContainer.GetBlockBlobReference($"{variantRule.ChapterName}.json");

                await blob.UploadTextAsync(json);
            }
        }
    }
}
