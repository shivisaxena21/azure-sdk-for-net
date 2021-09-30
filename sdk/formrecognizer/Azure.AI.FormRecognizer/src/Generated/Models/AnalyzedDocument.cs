// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object describing the location and semantic content of a document. </summary>
    public partial class AnalyzedDocument
    {
        /// <summary> Initializes a new instance of AnalyzedDocument. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="docType"/>, <paramref name="spans"/>, or <paramref name="fields"/> is null. </exception>
        internal AnalyzedDocument(string docType, IEnumerable<DocumentSpan> spans, IReadOnlyDictionary<string, DocumentField> fields, float confidence)
        {
            if (docType == null)
            {
                throw new ArgumentNullException(nameof(docType));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
            }

            DocType = docType;
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
            Fields = fields;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of AnalyzedDocument. </summary>
        /// <param name="docType"> Document type. </param>
        /// <param name="boundingRegions"> Bounding regions covering the document. </param>
        /// <param name="spans"> Location of the document in the reading order concatenated content. </param>
        /// <param name="fields"> Dictionary of named field values. </param>
        /// <param name="confidence"> Confidence of correctly extracting the document. </param>
        internal AnalyzedDocument(string docType, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans, IReadOnlyDictionary<string, DocumentField> fields, float confidence)
        {
            DocType = docType;
            BoundingRegions = boundingRegions;
            Spans = spans;
            Fields = fields;
            Confidence = confidence;
        }

        /// <summary> Document type. </summary>
        public string DocType { get; }
        /// <summary> Bounding regions covering the document. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the document in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Dictionary of named field values. </summary>
        public IReadOnlyDictionary<string, DocumentField> Fields { get; }
        /// <summary> Confidence of correctly extracting the document. </summary>
        public float Confidence { get; }
    }
}
