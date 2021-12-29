﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace HeBianGu.Base.WpfBase
{
    public static class ObservableExtension
    {
        public static void Sort<TSource, TKey>(this Collection<TSource> source, Func<TSource, TKey> keySelector)
        {
            List<TSource> sortedList = source.OrderBy(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }

        public static void Sort<TSource, TKey>(this Collection<TSource> source, Func<TSource, TKey> keySelector, bool isdesc)
        {
            List<TSource> sortedList = isdesc ? source.OrderByDescending(keySelector).ToList() : source.OrderBy(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }


        public static void SortDesc<TSource, TKey>(this Collection<TSource> source, Func<TSource, TKey> keySelector)
        {
            List<TSource> sortedList = source.OrderByDescending(keySelector).ToList();
            source.Clear();
            foreach (var sortedItem in sortedList)
                source.Add(sortedItem);
        }

        /// <summary> 排序 </summary>
        public static void Sort<T>(this ObservableCollection<T> collection) where T : IComparable
        {
            List<T> sortedList = collection.OrderBy(x => x).ToList();
            for (int i = 0; i < sortedList.Count(); i++)
            {
                collection.Move(collection.IndexOf(sortedList[i]), i);
            }
        }

        /// <summary> 转成 ObservableCollection 集合 </summary>
        public static ObservableCollection<T> ToObservable<T>(this IEnumerable<T> collection)
        {

            //ObservableCollection<T> result = new ObservableCollection<T>();
            //foreach (var item in collection)
            //{
            //    result.Add(item);
            //}
            return new ObservableCollection<T>(collection);

        }
        /// <summary> 调用主线程执行Action </summary>
        public static void Invoke<T>(this ObservableCollection<T> collection, Action<ObservableCollection<T>> action)
        {
            Application.Current.Dispatcher.Invoke(() => action(collection));

        }
        /// <summary> 调用主线程执行Action </summary>
        public static void BeginInvoke<T>(this ObservableCollection<T> collection, Action<ObservableCollection<T>> action)
        {
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.SystemIdle, new Action(() => action(collection)));

        }

        /// <summary> 更新集合 通知UI </summary>
        public static void Refresh<T>(this ObservableCollection<T> collection)
        {

            //ObservableCollection<T> result = new ObservableCollection<T>();

            //foreach (var item in collection)
            //{
            //    result.Add(item);
            //}

            //collection = result;

            collection = new ObservableCollection<T>(collection);
        }

        /// <summary> 对集合中的 每一项执行Action </summary>
        public static void Foreach<T>(this ObservableCollection<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
        /// <summary> 随机排序 </summary>
        public static ObservableCollection<T> Random<T>(this ObservableCollection<T> collection)
        {
            Random random = new Random();
            T temp;

            for (int i = 0; i < collection.Count; i++)
            {
                int index = random.Next(i, collection.Count - 1);

                temp = collection[i];

                collection[i] = collection[index];

                collection[index] = temp;
            }

            return collection;
        }

        /// <summary> 转成 ObservableCollection 集合 </summary>
        public static void RemoveAll<T>(this ObservableCollection<T> collection, Func<T, bool> predicate)
        {
            var finds = collection.Where(predicate).ToList();

            foreach (var item in finds)
            {
                collection.Remove(item);
            }
        }

        public static T CreateObservableCollection<T>(this Type t) where T : IEnumerable
        {
            if (t == null) return default(T);

            Type type = typeof(ObservableCollection<>);
            type = type.MakeGenericType(type);
            return (T)Activator.CreateInstance(type);
        }

        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> ts)
        {
            foreach (var item in ts)
            {
                collection.Add(item);
            }
        }

        public static void Replace<T>(this ObservableCollection<T> collection, T t, Predicate<T> predicate)
        {
            var find = collection.FirstOrDefault(l => predicate(l));

            if (find == null) return;

            var index = collection.IndexOf(find);

            collection.Remove(find);

            collection.Insert(index, t);

        }
    }
}
