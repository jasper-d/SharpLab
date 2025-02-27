using MirrorSharp.Advanced;
using Mono.Cecil;

namespace SharpLab.Server.Execution.Internal {
    public interface IAssemblyRewriter {
        void Rewrite(AssemblyDefinition assembly, IWorkSession session);
    }
}
