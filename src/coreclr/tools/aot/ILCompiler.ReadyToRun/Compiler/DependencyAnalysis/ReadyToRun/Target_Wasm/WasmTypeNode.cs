// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using ILCompiler.DependencyAnalysis;
using Internal.JitInterface;

namespace ILCompiler.DependencyAnalysis.ReadyToRun
{
    public class WasmTypeNode : ObjectNode
    {
        private readonly CorInfoWasmType[] _types;
        private readonly ObjectNodeSection _section;

        public WasmTypeNode(CorInfoWasmType[] types, ObjectNodeSection section)
            => (_types, _section) = (types, section);

        public override bool IsShareable => true;

        public override int ClassCode => -45678931;

        public override bool StaticDependenciesAreComputed => true;

        public override ObjectNodeSection GetSection(NodeFactory factory) => _section;

        protected override string GetName(NodeFactory factory) => $"WasmTypeNode" /* FIXME-WASM */;

        public override ObjectData GetData(NodeFactory factory, bool relocsOnly = false) => null;

        public override int CompareToImpl(ISortableNode other, CompilerComparer comparer)
            => 0 /* FIXME-WASM */;

        public void SetData(ObjectData data) => throw new NotImplementedException();
    }
}
