# Exceptional for ReSharper

Exceptional is an extension for ReSharper which analyzes thrown and documented C# exceptions and suggests improvements.

**Last Update: Date: 10.10.2025 - Resharper SDK 2025.2.3** Wave 252

### Motivation

When working with a code base - whether it is a small one or a big one - developers constantly encounter issues caused by wrong exception handling. There may be an excellent exception handling policy, but it is the developer who must execute this policy on its own code. Even with no policy defined, there are good practices on how to properly handle exceptions. This extension allows you to seamlessly apply these good practices with a couple of key strokes. 

Generally, the public API should be documented and thrown exceptions should be part of this documentation. But even if documenting thrown exceptions is pretty easy, the maintenance of the code that is using a particular method or property is not. This is where this extension comes into play: The extension analyzes call sites and provides hints on exceptions thrown from that invocations. If an exception is either not caught or not documented then you will be proposed to fix this problem. The extension also checks other good practices, for example that an inner exception is provided when rethrowing a new exception. 

## Installation

Requires ReSharper

- Open the ReSharper menu in Visual Studio and select Extension Manager... 
- Search for Exceptional and install the extension

Open the menu ReSharper / Options... / Exceptional to configure the extension.

For locally installation: [Installation](Installation.md)

Check out the extension in the ReSharper plugin gallery (targets the latest R# version): 
 
- [Exceptional for ReSharper](https://resharper-plugins.jetbrains.com/packages/ExceptionalDevs.Exceptional.MF/)

Check out old versions: 

- [Exceptional for ReSharper - All versions](https://plugins.jetbrains.com/plugin/14928-exceptional-by-mf/versions)

## Features

### Thrown exception not documented or caught

**Warning:** Exceptions thrown outside the scope of method\property that are not documented in methods xml documentation (thrown with use of throw keyword).

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/01.png)

**Fix:** Document or catch thrown exception.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/01_fix.png)

**Warning:** Exception thrown outside the scope of method\property that are not documented in methods xml documentation (thrown from another invocation).

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/02.png)

**Fix:** Document or catch thrown exception.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/02_fix.png)

### Documented exception is not thrown

**Warning:** Exceptions documented in XML documentation that are not thrown from method/property.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/03.png)

**Fix:** Remove documentation of not thrown exception.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/03_fix.png)

### Catch-all clauses

**Warning:** General catch-all clauses should be avoided.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/04.png)

### Not passing inner exception

**Warning:** Throwing new exception from catch clause should include message and inner exception.

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/05.png)

**Fix:** Include inner exception in ctor

![](https://rawgit.com/CSharpAnalyzers/ExceptionalReSharper/master/assets/05_fix.png)

### Do not throw System.Exception

**Warning:** Throwing System.Exception should be avoided.

More features to come...
