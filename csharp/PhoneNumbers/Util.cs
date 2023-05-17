/*
 * Copyright (C) 2011 Patrick Mezard
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PhoneNumbers.Test, PublicKey=002400000480000014020000060200000024000052534131001000000100010049734e2f3a3855389df028d2221c6e889918d8b1e627a266c5a87802fb79517eb774901c7a14cd45b3ecfd0870d4c6cdd062d25651b5d5c769b15c1352fad4ebd0561c2bbe2aff3c1d35b71c91cbd509b4e7fcdf085ab28dd33b3835add2008485fe89e09cdbe5e07683f1b39934b6bb733ee42e2a10a4359eed51cd482fd3f23fa479af0d338dd97ab8142b7a6fcd52a28f054f05d7d306c916c0fe1fb2a97e015cfe30e4a27cb6253165a192be9969cfefe6b38993deeb25ca92a4b59c52a174a9bcadab7ccbfb355c05e365d7f682da1dc02ba626688419c7d19ea4a715ad8581a08a46afbba9f077953e0ee7a67d9dc127c0459efd6971c779e212b6d1f66ab8da8a5ac8e65c39e6f01ca4c4d678ed070068e3b6e50145dce0a0846065a0064227ab5ed77d037fbda0b6965fa914f0c6a62f6d12aff937aed59c8047bceb3086907a737c21a543e7615b0063c57a82daf975d374f2b3750741d72c2187b03eadc5686cab3a9d7b7a80fc31fbb1aa665fa7d78c5debe5b9ee4270d21591ac08122f0c2fedaf6c52b7d186868414a764119ed4bf0d7d29cbc8b04538bc0cd6186c15c3ad5766890684deec73223c0083040ceb3ff9ac3e8e548c1c7e222ffae80031380a5859093205f393a47ddc80045efb552b31104ac56e1027d1588971a7b3fb202544992bc31b054e5c74f18d3ac10468fe357285590158f4926f79be")]

namespace PhoneNumbers
{
    internal class EnumerableFromConstructor<T> : IEnumerable<T>
    {
        private readonly Func<IEnumerator<T>> fn;

        public EnumerableFromConstructor(Func<IEnumerator<T>> fn)
        {
            this.fn = fn;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return fn();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return fn();
        }
    }
}
