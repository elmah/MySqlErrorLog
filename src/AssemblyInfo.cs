#region Copyright 2009 Nick Berardi. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

#region Imports

using System.Reflection;

using CLSCompliantAttribute = System.CLSCompliantAttribute;
using ComVisible = System.Runtime.InteropServices.ComVisibleAttribute;
using InternalsVisibleToAttribute = System.Runtime.CompilerServices.InternalsVisibleToAttribute;

#endregion

[assembly: AssemblyTitle("Elmah.MySql")]
[assembly: AssemblyDescription("MySQL Support for ELMAH")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ELMAH")]
[assembly: AssemblyCopyright("Copyright \u00a9 2009, Nick Berardi. All rights reserved.")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("2.0.11227.0")]
[assembly: AssemblyFileVersion("2.0.11227.2305")]
[assembly: AssemblyConfiguration(Elmah.Build.Configuration)]

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

[assembly: InternalsVisibleTo("Elmah.Tests")]
