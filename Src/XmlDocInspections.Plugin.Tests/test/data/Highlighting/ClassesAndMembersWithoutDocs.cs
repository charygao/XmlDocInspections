﻿using System;

#pragma warning disable 67
#pragma warning disable 169
#pragma warning disable 649

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable InconsistentNaming
// ReSharper disable EventNeverSubscribedTo.Global
// ReSharper disable EventNeverSubscribedTo.Local
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedParameter.Local

namespace XmlDocInspections.Sample.Highlighting
{
    public class PublicClassWithoutDocs : IToBeExplicitlyImplementedInterface
    {
        public string PublicField;

        internal string InternalField;

        protected internal string ProtectedInternalField;

        protected string ProtectedField;

        private string PrivateField;

        //

        public PublicClassWithoutDocs()
        {
        }

        public PublicClassWithoutDocs(string a)
        {
        }

        //

        public string PublicProperty { get; set; }

        internal string InternalProperty { get; set; }

        protected internal string ProtectedInternalProperty { get; set; }

        protected string ProtectedProperty { get; set; }

        private string PrivateProperty { get; set; }

        //

        public void PublicMethod(string a)
        {
        }

        void IToBeExplicitlyImplementedInterface.Method()
        {
        }

        internal void InternalMethod()
        {
        }

        protected void ProtectedMethod()
        {
        }

        protected internal void ProtectedInternalMethod()
        {
        }

        private void PrivateMethod()
        {
        }

        public class PublicNestedClass
        {
        }

        internal class InternalNestedClass
        {
        }

        protected internal class ProtectedInternalNestedClass
        {
        }

        protected class ProtectedNestedClass
        {
        }

        private class PrivateNestedClass
        {
        }

        //

        public event EventHandler PublicEvent;

        internal event EventHandler InternalEvent;

        protected internal event EventHandler ProtectedInternalEvent;

        protected event EventHandler ProtectedEvent;

        private event EventHandler PrivateEvent;

        //

        public static PublicClassWithoutDocs operator +(PublicClassWithoutDocs left, PublicClassWithoutDocs right)
        {
            return new PublicClassWithoutDocs();
        }
    }
}
