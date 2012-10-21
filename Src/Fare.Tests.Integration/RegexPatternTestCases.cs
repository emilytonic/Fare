﻿using System.Collections;
using System.Collections.Generic;

namespace Fare.Tests.Integration
{
    public class RegexPatternTestCases : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "[ab]{4,6}" };
            yield return new object[] { "[ab]{4,6}c" };
            yield return new object[] { "(a|b)*ab" };
            yield return new object[] { "[A-Za-z0-9]" };
            yield return new object[] { "[A-Za-z0-9_]" };
            yield return new object[] { "[A-Za-z]" };
            yield return new object[] { "[ \t]" };
            yield return new object[] { @"[(?<=\W)(?=\w)|(?<=\w)(?=\W)]" };
            yield return new object[] { "[\x00-\x1F\x7F]" };
            yield return new object[] { "[0-9]" };
            yield return new object[] { "[^0-9]" };
            yield return new object[] { "[\x21-\x7E]" };
            yield return new object[] { "[a-z]" };
            yield return new object[] { "[\x20-\x7E]" };
            yield return new object[] { "[ \t\r\n\v\f]" };
            yield return new object[] { "[^ \t\r\n\v\f]" };
            yield return new object[] { "[A-Z]" };
            yield return new object[] { "[A-Fa-f0-9]" };
            yield return new object[] { "in[du]" };
            yield return new object[] { "x[0-9A-Z]" };
            yield return new object[] { "[^A-M]in" };
            yield return new object[] { ".gr" };
            yield return new object[] { @"\(.*l" };
            yield return new object[] { "W*in" };
            yield return new object[] { "[xX][0-9a-z]" };
            yield return new object[] { @"\(\(\(ab\)*c\)*d\)\(ef\)*\(gh\)\{2\}\(ij\)*\(kl\)*\(mn\)*\(op\)*\(qr\)*" };
            yield return new object[] { @"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$" };
            yield return new object[] { @"((mailto\:|(news|(ht|f)tp(s?))\://){1}\S+)" };
            yield return new object[] { @"^http\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$" };
            yield return new object[] { @"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?" };
            yield return new object[] { @"^(http|https|ftp)\://([a-zA-Z0-9\.\-]+(\:[a-zA-Z0-9\.&amp;%\$\-]+)*@)?((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|([a-zA-Z0-9\-]+\.)*[a-zA-Z0-9\-]+\.[a-zA-Z]{2,4})(\:[0-9]+)?(/[^/][a-zA-Z0-9\.\,\?\'\\/\+&amp;%\$#\=~_\-@]*)*$" };
            yield return new object[] { @"^([1-zA-Z0-1@.\s]{1,255})$" };
            yield return new object[] { "[A-Z][0-9A-Z]{10}" };
            yield return new object[] { "[A-Z][A-Za-z0-9]{10}" };
            yield return new object[] { "[A-Z][a-zA-Z0-9]{10}" };
            yield return new object[] { "[A-Za-z0-9]{11}" };
            yield return new object[] { "[A-Za-z]{11}" };
            yield return new object[] { @"^[a-zA-Z''-'\s]{1,40}$" };
            yield return new object[] { @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$" };
            yield return new object[] { @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$" };
            yield return new object[] { @"[A-Z][0-9A-Z]{10}" };
            yield return new object[] { @"[A-Z][a-zA-Z0-9]{10}" };
            yield return new object[] { @"[A-Za-z0-9]{11}" };
            yield return new object[] { @"[A-Za-z]{11}" };
            yield return new object[] { @"a[a-z]" };
            yield return new object[] { @"[1-9][0-9]" };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
