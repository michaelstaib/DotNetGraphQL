﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class MyQueries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            106,
            85,
            50,
            100,
            50,
            65,
            70,
            106,
            56,
            106,
            105,
            89,
            102,
            57,
            43,
            120,
            77,
            81,
            98,
            54,
            57,
            65,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            65,
            108,
            108,
            68,
            111,
            103,
            115,
            32,
            123,
            32,
            100,
            111,
            103,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            68,
            111,
            103,
            73,
            109,
            97,
            103,
            101,
            32,
            125,
            32,
            125,
            32,
            113,
            117,
            101,
            114,
            121,
            32,
            103,
            101,
            116,
            68,
            111,
            103,
            115,
            66,
            121,
            67,
            111,
            97,
            116,
            67,
            111,
            108,
            111,
            114,
            40,
            36,
            99,
            111,
            97,
            116,
            67,
            111,
            108,
            111,
            114,
            58,
            32,
            83,
            116,
            114,
            105,
            110,
            103,
            33,
            41,
            32,
            123,
            32,
            100,
            111,
            103,
            115,
            40,
            119,
            104,
            101,
            114,
            101,
            58,
            32,
            123,
            32,
            99,
            111,
            97,
            116,
            67,
            111,
            108,
            111,
            114,
            95,
            99,
            111,
            110,
            116,
            97,
            105,
            110,
            115,
            58,
            32,
            36,
            99,
            111,
            97,
            116,
            67,
            111,
            108,
            111,
            114,
            32,
            125,
            41,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            46,
            46,
            46,
            32,
            68,
            111,
            103,
            73,
            109,
            97,
            103,
            101,
            32,
            125,
            32,
            125,
            32,
            102,
            114,
            97,
            103,
            109,
            101,
            110,
            116,
            32,
            68,
            111,
            103,
            73,
            109,
            97,
            103,
            101,
            32,
            111,
            110,
            32,
            68,
            111,
            103,
            73,
            109,
            97,
            103,
            101,
            115,
            77,
            111,
            100,
            101,
            108,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            97,
            118,
            97,
            116,
            97,
            114,
            85,
            114,
            108,
            32,
            98,
            105,
            114,
            116,
            104,
            68,
            97,
            116,
            101,
            32,
            98,
            114,
            101,
            101,
            100,
            32,
            99,
            111,
            97,
            116,
            67,
            111,
            108,
            111,
            114,
            32,
            105,
            109,
            97,
            103,
            101,
            115,
            76,
            105,
            115,
            116,
            32,
            116,
            105,
            116,
            108,
            101,
            32,
            119,
            101,
            98,
            115,
            105,
            116,
            101,
            85,
            114,
            108,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static MyQueries Default { get; } = new MyQueries();

        public override string ToString() => 
            @"query getAllDogs {
              dogs {
                ... DogImage
              }
            }
            
            query getDogsByCoatColor($coatColor: String!) {
              dogs(where: { coatColor_contains: $coatColor }) {
                ... DogImage
              }
            }
            
            fragment DogImage on DogImagesModel {
              avatarUrl
              birthDate
              breed
              coatColor
              imagesList
              title
              websiteUrl
            }";
    }
}
