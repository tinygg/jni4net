//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface List : global::java.util.Collection, global::java.lang.Iterable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/Object;)V")]
        void add(int par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/Object;")]
        global::java.lang.Object get(int par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        int indexOf(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        int lastIndexOf(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/util/Collection;)Z")]
        bool addAll(int par0, global::java.util.Collection par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/lang/Object;")]
        global::java.lang.Object remove(int par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(ILjava/lang/Object;)Ljava/lang/Object;")]
        global::java.lang.Object set(int par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(II)Ljava/util/List;")]
        global::java.util.List subList(int par0, int par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Ljava/util/Iterator;")]
        global::java.util.Iterator listIterator(int par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Iterator;")]
        global::java.util.Iterator listIterator();
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class List_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.@__List.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.List))]
    internal sealed unsafe partial class @__List : global::java.lang.Object, global::java.util.List {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _iterator0;
        
        internal static global::net.sf.jni4net.jni.MethodId _add1;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode2;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear3;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals4;
        
        internal static global::net.sf.jni4net.jni.MethodId _contains5;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty6;
        
        internal static global::net.sf.jni4net.jni.MethodId _addAll7;
        
        internal static global::net.sf.jni4net.jni.MethodId _size8;
        
        internal static global::net.sf.jni4net.jni.MethodId _toArray9;
        
        internal static global::net.sf.jni4net.jni.MethodId _toArray10;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove11;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsAll12;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeAll13;
        
        internal static global::net.sf.jni4net.jni.MethodId _retainAll14;
        
        internal static global::net.sf.jni4net.jni.MethodId _add15;
        
        internal static global::net.sf.jni4net.jni.MethodId _get16;
        
        internal static global::net.sf.jni4net.jni.MethodId _indexOf17;
        
        internal static global::net.sf.jni4net.jni.MethodId _lastIndexOf18;
        
        internal static global::net.sf.jni4net.jni.MethodId _addAll19;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove20;
        
        internal static global::net.sf.jni4net.jni.MethodId _set21;
        
        internal static global::net.sf.jni4net.jni.MethodId _subList22;
        
        internal static global::net.sf.jni4net.jni.MethodId _listIterator23;
        
        internal static global::net.sf.jni4net.jni.MethodId _listIterator24;
        
        protected @__List(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.util.@__List.staticClass = staticClass;
            global::java.util.@__List._iterator0 = env.GetMethodID(global::java.util.@__List.staticClass, "iterator", "()Ljava/util/Iterator;");
            global::java.util.@__List._add1 = env.GetMethodID(global::java.util.@__List.staticClass, "add", "(Ljava/lang/Object;)Z");
            global::java.util.@__List._hashCode2 = env.GetMethodID(global::java.util.@__List.staticClass, "hashCode", "()I");
            global::java.util.@__List._clear3 = env.GetMethodID(global::java.util.@__List.staticClass, "clear", "()V");
            global::java.util.@__List._equals4 = env.GetMethodID(global::java.util.@__List.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.util.@__List._contains5 = env.GetMethodID(global::java.util.@__List.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.@__List._isEmpty6 = env.GetMethodID(global::java.util.@__List.staticClass, "isEmpty", "()Z");
            global::java.util.@__List._addAll7 = env.GetMethodID(global::java.util.@__List.staticClass, "addAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__List._size8 = env.GetMethodID(global::java.util.@__List.staticClass, "size", "()I");
            global::java.util.@__List._toArray9 = env.GetMethodID(global::java.util.@__List.staticClass, "toArray", "()[Ljava/lang/Object;");
            global::java.util.@__List._toArray10 = env.GetMethodID(global::java.util.@__List.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
            global::java.util.@__List._remove11 = env.GetMethodID(global::java.util.@__List.staticClass, "remove", "(Ljava/lang/Object;)Z");
            global::java.util.@__List._containsAll12 = env.GetMethodID(global::java.util.@__List.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__List._removeAll13 = env.GetMethodID(global::java.util.@__List.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__List._retainAll14 = env.GetMethodID(global::java.util.@__List.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__List._add15 = env.GetMethodID(global::java.util.@__List.staticClass, "add", "(ILjava/lang/Object;)V");
            global::java.util.@__List._get16 = env.GetMethodID(global::java.util.@__List.staticClass, "get", "(I)Ljava/lang/Object;");
            global::java.util.@__List._indexOf17 = env.GetMethodID(global::java.util.@__List.staticClass, "indexOf", "(Ljava/lang/Object;)I");
            global::java.util.@__List._lastIndexOf18 = env.GetMethodID(global::java.util.@__List.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
            global::java.util.@__List._addAll19 = env.GetMethodID(global::java.util.@__List.staticClass, "addAll", "(ILjava/util/Collection;)Z");
            global::java.util.@__List._remove20 = env.GetMethodID(global::java.util.@__List.staticClass, "remove", "(I)Ljava/lang/Object;");
            global::java.util.@__List._set21 = env.GetMethodID(global::java.util.@__List.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
            global::java.util.@__List._subList22 = env.GetMethodID(global::java.util.@__List.staticClass, "subList", "(II)Ljava/util/List;");
            global::java.util.@__List._listIterator23 = env.GetMethodID(global::java.util.@__List.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
            global::java.util.@__List._listIterator24 = env.GetMethodID(global::java.util.@__List.staticClass, "listIterator", "()Ljava/util/ListIterator;");
        }
        
        public global::java.util.Iterator iterator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Iterator>(env.CallObjectMethod(this, global::java.util.@__List._iterator0));
        }
        
        public bool add(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._add1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__List._hashCode2);
        }
        
        public void clear() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.@__List._clear3);
        }
        
        public bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._equals4, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool contains(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._contains5, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._isEmpty6);
        }
        
        public bool addAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._addAll7, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public int size() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__List._size8);
        }
        
        public java.lang.Object[] toArray() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Object[])(env.ConvertArrayToNet<java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__List._toArray9))));
        }
        
        public java.lang.Object[] toArray(java.lang.Object[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.Object[])(env.ConvertArrayToNet<java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__List._toArray10, global::net.sf.jni4net.jni.Value.CreateArray(par0)))));
        }
        
        public bool remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._remove11, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool containsAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._containsAll12, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool removeAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._removeAll13, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool retainAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._retainAll14, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public void add(int par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.@__List._add15, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        public global::java.lang.Object get(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__List._get16, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public int indexOf(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__List._indexOf17, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public int lastIndexOf(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.util.@__List._lastIndexOf18, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public bool addAll(int par0, global::java.util.Collection par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__List._addAll19, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        public global::java.lang.Object remove(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__List._remove20, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public global::java.lang.Object set(int par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__List._set21, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        public global::java.util.List subList(int par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.List>(env.CallObjectMethod(this, global::java.util.@__List._subList22, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1)));
        }
        
        public global::java.util.Iterator listIterator(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Iterator>(env.CallObjectMethod(this, global::java.util.@__List._listIterator23, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        public global::java.util.Iterator listIterator() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.util.Iterator>(env.CallObjectMethod(this, global::java.util.@__List._listIterator24));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__List);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "iterator", "iterator0", "()Ljava/util/Iterator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "add", "add1", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "hashCode", "hashCode2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "clear", "clear3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "equals", "equals4", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "contains", "contains5", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isEmpty", "isEmpty6", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "addAll", "addAll7", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "size", "size8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "toArray", "toArray9", "()[Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "toArray", "toArray10", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "remove", "remove11", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "containsAll", "containsAll12", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "removeAll", "removeAll13", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "retainAll", "retainAll14", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "add", "add15", "(ILjava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "get", "get16", "(I)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "indexOf", "indexOf17", "(Ljava/lang/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "lastIndexOf", "lastIndexOf18", "(Ljava/lang/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "addAll", "addAll19", "(ILjava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "remove", "remove20", "(I)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "set", "set21", "(ILjava/lang/Object;)Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "subList", "subList22", "(II)Ljava/util/List;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "listIterator", "listIterator23", "(I)Ljava/util/ListIterator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "listIterator", "listIterator24", "()Ljava/util/ListIterator;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* iterator0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/Iterator;
            // ()Ljava/util/Iterator;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::java.lang.Iterable)(real)).iterator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool add1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).add(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int hashCode2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).hashCode();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void clear3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            ((global::java.util.Collection)(real)).clear();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static bool equals4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).equals(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool contains5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).contains(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool isEmpty6(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).isEmpty();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool addAll7(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).addAll(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Collection>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int size8(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).size();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* toArray9(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[Ljava/lang/Object;
            // ()[Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::java.util.Collection)(real)).toArray());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* toArray10(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // ([Ljava/lang/Object;)[Ljava/lang/Object;
            // ([Ljava/lang/Object;)[Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::java.util.Collection)(real)).toArray(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.Object[]>(__env, par0)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool remove11(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).remove(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool containsAll12(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).containsAll(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Collection>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool removeAll13(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).removeAll(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Collection>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool retainAll14(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return ((global::java.util.Collection)(real)).retainAll(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Collection>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static void add15(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0, global::java.lang.Object.JavaPtr* par1) {
            // (ILjava/lang/Object;)V
            // (ILjava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            real.add(par0, global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par1));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::java.lang.Object.JavaPtr* get16(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0) {
            // (I)Ljava/lang/Object;
            // (I)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.get(par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static int indexOf17(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)I
            // (Ljava/lang/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return real.indexOf(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static int lastIndexOf18(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* par0) {
            // (Ljava/lang/Object;)I
            // (Ljava/lang/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return real.lastIndexOf(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static bool addAll19(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0, global::java.lang.Object.JavaPtr* par1) {
            // (ILjava/util/Collection;)Z
            // (ILjava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return real.addAll(par0, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Collection>(__env, par1));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* remove20(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0) {
            // (I)Ljava/lang/Object;
            // (I)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.remove(par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* set21(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0, global::java.lang.Object.JavaPtr* par1) {
            // (ILjava/lang/Object;)Ljava/lang/Object;
            // (ILjava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.set(par0, global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<java.lang.Object>(__env, par1)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* subList22(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0, int par1) {
            // (II)Ljava/util/List;
            // (II)Ljava/util/List;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.subList(par0, par1));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* listIterator23(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, int par0) {
            // (I)Ljava/util/ListIterator;
            // (I)Ljava/util/Iterator;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.listIterator(par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* listIterator24(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/util/ListIterator;
            // ()Ljava/util/Iterator;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.util.List real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.List>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.listIterator());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.util.@__List(env);
            }
        }
    }
    #endregion
}
