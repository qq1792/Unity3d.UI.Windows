﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class EnumerableExtensions {

	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source) {

	    const int seed = 1;
		Random rng = new Random(seed);
		T[] sourceArray = source.ToArray();
		
		for (int n = 0; n < sourceArray.Length; n++) {

			int k = rng.Next(n, sourceArray.Length);
			yield return sourceArray[k];
			
			sourceArray[k] = sourceArray[n];

		}

	}

}