﻿using System;
using System.Collections.Generic;

namespace Colourful.Strategy
{
    public class ConverterFactory : IConverterFactory
    {
        private readonly List<IConversionStrategy> _conversionStrategies = new List<IConversionStrategy>();
        
        public void RegisterStrategy(IConversionStrategy conversionStrategy)
        {
            _conversionStrategies.Add(conversionStrategy);
        }

        public IColorConverter<TSource, TTarget> CreateConverter<TSource, TTarget>(in IConversionMetadata sourceMetadata, in IConversionMetadata targetMetadata)
            where TSource : struct
            where TTarget : struct
        {
            var conversionStrategies = _conversionStrategies;

            if (typeof(TSource) == typeof(TTarget))
            {
                foreach (var conversionStrategy in conversionStrategies)
                {
                    if (conversionStrategy.TrySame<TSource>(in sourceMetadata, in targetMetadata, this) is IColorConverter<TSource, TTarget> converter)
                        return converter;
                }
            }
            else
            {
                foreach (var conversionStrategy in conversionStrategies)
                {
                    if (conversionStrategy.TryConvert<TSource, TTarget>(in sourceMetadata, in targetMetadata, this) is IColorConverter<TSource, TTarget> converter)
                        return converter;
                }

                foreach (var conversionStrategy in conversionStrategies)
                {
                    if (conversionStrategy.TryConvertToAnyTarget<TSource, TTarget>(in sourceMetadata, in targetMetadata, this) is IColorConverter<TSource, TTarget> converter)
                        return converter;
                }

                foreach (var conversionStrategy in conversionStrategies)
                {
                    if (conversionStrategy.TryConvertFromAnySource<TSource, TTarget>(in sourceMetadata, in targetMetadata, this) is IColorConverter<TSource, TTarget> converter)
                        return converter;
                }
            }

            throw new InvalidOperationException("Conversion not possible according to registered strategies.");
        }
    }
}