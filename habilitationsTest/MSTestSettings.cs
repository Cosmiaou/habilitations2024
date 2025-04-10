using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Text;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]