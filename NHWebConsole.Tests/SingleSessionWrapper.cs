﻿using System;
using System.Collections;
using System.Data;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Stat;
using NHibernate.Type;

namespace NHWebConsole.Tests {
    public class SingleSessionWrapper : ISession {
        private readonly ISession session;

        public SingleSessionWrapper(ISession session) {
            this.session = session;
        }

        public void Kill() {
            session.Dispose();
        }

        public void Dispose() {
            //session.Dispose();
        }

        public void Flush() {
            session.Flush();
        }

        public IDbConnection Disconnect() {
            return session.Disconnect();
        }

        public void Reconnect() {
            session.Reconnect();
        }

        public void Reconnect(IDbConnection connection) {
            session.Reconnect(connection);
        }

        public IDbConnection Close() {
            return session.Close();
        }

        public void CancelQuery() {
            session.CancelQuery();
        }

        public bool IsDirty() {
            return session.IsDirty();
        }

        public object GetIdentifier(object obj) {
            return session.GetIdentifier(obj);
        }

        public bool Contains(object obj) {
            return session.Contains(obj);
        }

        public void Evict(object obj) {
            session.Evict(obj);
        }

        public object Load(Type theType, object id, LockMode lockMode) {
            return session.Load(theType, id, lockMode);
        }

        public object Load(string entityName, object id, LockMode lockMode) {
            return session.Load(entityName, id, lockMode);
        }

        public object Load(Type theType, object id) {
            return session.Load(theType, id);
        }

        public T Load<T>(object id, LockMode lockMode) {
            return session.Load<T>(id, lockMode);
        }

        public T Load<T>(object id) {
            return session.Load<T>(id);
        }

        public object Load(string entityName, object id) {
            return session.Load(entityName, id);
        }

        public void Load(object obj, object id) {
            session.Load(obj, id);
        }

        public void Replicate(object obj, ReplicationMode replicationMode) {
            session.Replicate(obj, replicationMode);
        }

        public void Replicate(string entityName, object obj, ReplicationMode replicationMode) {
            session.Replicate(entityName, obj, replicationMode);
        }

        public object Save(object obj) {
            return session.Save(obj);
        }

        public void Save(object obj, object id) {
            session.Save(obj, id);
        }

        public object Save(string entityName, object obj) {
            return session.Save(entityName, obj);
        }

        public void SaveOrUpdate(object obj) {
            session.SaveOrUpdate(obj);
        }

        public void SaveOrUpdate(string entityName, object obj) {
            session.SaveOrUpdate(entityName, obj);
        }

        public void Update(object obj) {
            session.Update(obj);
        }

        public void Update(object obj, object id) {
            session.Update(obj, id);
        }

        public void Update(string entityName, object obj) {
            session.Update(entityName, obj);
        }

        public object Merge(object obj) {
            return session.Merge(obj);
        }

        public object Merge(string entityName, object obj) {
            return session.Merge(entityName, obj);
        }

        public void Persist(object obj) {
            session.Persist(obj);
        }

        public void Persist(string entityName, object obj) {
            session.Persist(entityName, obj);
        }

        public object SaveOrUpdateCopy(object obj) {
            return session.SaveOrUpdateCopy(obj);
        }

        public object SaveOrUpdateCopy(object obj, object id) {
            return session.SaveOrUpdateCopy(obj, id);
        }

        public void Delete(object obj) {
            session.Delete(obj);
        }

        public void Delete(string entityName, object obj) {
            session.Delete(entityName, obj);
        }

        public IList Find(string query) {
            return session.Find(query);
        }

        public IList Find(string query, object value, IType type) {
            return session.Find(query, value, type);
        }

        public IList Find(string query, object[] values, IType[] types) {
            return session.Find(query, values, types);
        }

        public IEnumerable Enumerable(string query) {
            return session.Enumerable(query);
        }

        public IEnumerable Enumerable(string query, object value, IType type) {
            return session.Enumerable(query, value, type);
        }

        public IEnumerable Enumerable(string query, object[] values, IType[] types) {
            return session.Enumerable(query, values, types);
        }

        public ICollection Filter(object collection, string filter) {
            return session.Filter(collection, filter);
        }

        public ICollection Filter(object collection, string filter, object value, IType type) {
            return session.Filter(collection, filter, value, type);
        }

        public ICollection Filter(object collection, string filter, object[] values, IType[] types) {
            return session.Filter(collection, filter, values, types);
        }

        public int Delete(string query) {
            return session.Delete(query);
        }

        public int Delete(string query, object value, IType type) {
            return session.Delete(query, value, type);
        }

        public int Delete(string query, object[] values, IType[] types) {
            return session.Delete(query, values, types);
        }

        public void Lock(object obj, LockMode lockMode) {
            session.Lock(obj, lockMode);
        }

        public void Lock(string entityName, object obj, LockMode lockMode) {
            session.Lock(entityName, obj, lockMode);
        }

        public void Refresh(object obj) {
            session.Refresh(obj);
        }

        public void Refresh(object obj, LockMode lockMode) {
            session.Refresh(obj, lockMode);
        }

        public LockMode GetCurrentLockMode(object obj) {
            return session.GetCurrentLockMode(obj);
        }

        public ITransaction BeginTransaction() {
            return session.BeginTransaction();
        }

        public ITransaction BeginTransaction(IsolationLevel isolationLevel) {
            return session.BeginTransaction(isolationLevel);
        }

        public ICriteria CreateCriteria<T>() where T : class {
            return session.CreateCriteria<T>();
        }

        public ICriteria CreateCriteria<T>(string alias) where T : class {
            return session.CreateCriteria<T>(alias);
        }

        public ICriteria CreateCriteria(Type persistentClass) {
            return session.CreateCriteria(persistentClass);
        }

        public ICriteria CreateCriteria(Type persistentClass, string alias) {
            return session.CreateCriteria(persistentClass, alias);
        }

        public ICriteria CreateCriteria(string entityName) {
            return session.CreateCriteria(entityName);
        }

        public ICriteria CreateCriteria(string entityName, string alias) {
            return session.CreateCriteria(entityName, alias);
        }

        public IQuery CreateQuery(string queryString) {
            return session.CreateQuery(queryString);
        }

        public IQuery CreateFilter(object collection, string queryString) {
            return session.CreateFilter(collection, queryString);
        }

        public IQuery GetNamedQuery(string queryName) {
            return session.GetNamedQuery(queryName);
        }

        public IQuery CreateSQLQuery(string sql, string returnAlias, Type returnClass) {
            return session.CreateSQLQuery(sql, returnAlias, returnClass);
        }

        public IQuery CreateSQLQuery(string sql, string[] returnAliases, Type[] returnClasses) {
            return session.CreateSQLQuery(sql, returnAliases, returnClasses);
        }

        public ISQLQuery CreateSQLQuery(string queryString) {
            return session.CreateSQLQuery(queryString);
        }

        public void Clear() {
            session.Clear();
        }

        public object Get(Type clazz, object id) {
            return session.Get(clazz, id);
        }

        public object Get(Type clazz, object id, LockMode lockMode) {
            return session.Get(clazz, id, lockMode);
        }

        public object Get(string entityName, object id) {
            return session.Get(entityName, id);
        }

        public T Get<T>(object id) {
            return session.Get<T>(id);
        }

        public T Get<T>(object id, LockMode lockMode) {
            return session.Get<T>(id, lockMode);
        }

        public string GetEntityName(object obj) {
            return session.GetEntityName(obj);
        }

        public IFilter EnableFilter(string filterName) {
            return session.EnableFilter(filterName);
        }

        public IFilter GetEnabledFilter(string filterName) {
            return session.GetEnabledFilter(filterName);
        }

        public void DisableFilter(string filterName) {
            session.DisableFilter(filterName);
        }

        public IMultiQuery CreateMultiQuery() {
            return session.CreateMultiQuery();
        }

        public ISession SetBatchSize(int batchSize) {
            return session.SetBatchSize(batchSize);
        }

        public ISessionImplementor GetSessionImplementation() {
            return session.GetSessionImplementation();
        }

        public IMultiCriteria CreateMultiCriteria() {
            return session.CreateMultiCriteria();
        }

        public ISession GetSession(EntityMode entityMode) {
            return session.GetSession(entityMode);
        }

        public EntityMode ActiveEntityMode {
            get { return session.ActiveEntityMode; }
        }

        public FlushMode FlushMode {
            get { return session.FlushMode; }
            set { session.FlushMode = value; }
        }

        public CacheMode CacheMode {
            get { return session.CacheMode; }
            set { session.CacheMode = value; }
        }

        public ISessionFactory SessionFactory {
            get { return session.SessionFactory; }
        }

        public IDbConnection Connection {
            get { return session.Connection; }
        }

        public bool IsOpen {
            get { return session.IsOpen; }
        }

        public bool IsConnected {
            get { return session.IsConnected; }
        }

        public ITransaction Transaction {
            get { return session.Transaction; }
        }

        public ISessionStatistics Statistics {
            get { return session.Statistics; }
        }
    }
}