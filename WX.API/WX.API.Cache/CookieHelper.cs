using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Http;


public class CookieHelper
{
    const string COOKIE_PATH = "/";
    const string COOKIE_DOMAIN = "localhost";
    const string COOKIE_VERSION = "1";
    public static int COOKIE_EXPIRE = 86400;//Ĭ�Ϲ���ʱ��24Сʱ

    /// <summary>
    /// ȡ��cookie
    /// </summary>
    /// <param name="cookieName"></param>
    /// <returns></returns>
    public static string GetCookie(string cookieName)
    {

        HttpCookie cookie = HttpContext.Current.Request.Cookies[cookieName];
        if (cookie == null)
        {
            return "";
        }
        else
        {
            return cookie.Value.ToString();
        }
    }

    /// <summary>
    /// ��Ĭ��ʱ������cookie
    /// </summary>
    /// <param name="cookieName"></param>
    /// <param name="cookieValue"></param>
    public static void SetCookie(string cookieName, string cookieValue)
    {

        HttpCookie cookie = new HttpCookie(cookieName);

        cookie.Domain = COOKIE_DOMAIN;//����cookie��
        cookie.Path = COOKIE_PATH;
        cookie.Expires = DateTime.Now.AddSeconds(COOKIE_EXPIRE);
        cookie.Value = HttpUtility.UrlEncode(cookieValue);

        HttpContext.Current.Response.Cookies.Add(cookie);
    }

    /// <summary>
    /// ����������cookie
    /// </summary>
    /// <param name="cookieName"></param>
    /// <param name="cookieValue"></param>
    /// <param name="saveStatus">�Ƿ����ñ���</param>
    /// <param name="httpOnly">�Ƿ���ֻ��ͨ��http����</param>
    public static void SetCookie(string cookieName, string cookieValue, bool saveStatus, bool httpOnly)
    {
        HttpCookie cookie = new HttpCookie(cookieName);
        cookie.Domain = COOKIE_DOMAIN;
        cookie.Path = COOKIE_PATH;
        if (saveStatus)
        {
            cookie.Expires = DateTime.MaxValue;
        }
        else
        {
            cookie.Expires = DateTime.Now.AddSeconds(COOKIE_EXPIRE);
        }

        if (httpOnly)
        {
            cookie.HttpOnly = true;
        }
        cookie.Value = HttpUtility.UrlEncode(cookieValue);
        HttpContext.Current.Response.Cookies.Add(cookie);
    }

    /// <summary>
    /// ���cookie
    /// </summary>
    /// <param name="cookieName"></param>c
    /// <returns></returns>
    public static bool DeleteCookie(string cookieName)
    {
        bool ReturnBoolValue = false;
        HttpCookie httpCookie = new HttpCookie(cookieName);
        if (httpCookie != null)
        {
            httpCookie.Domain = COOKIE_DOMAIN;
            httpCookie.Path = "/";
            httpCookie.Expires = DateTime.Now.AddDays(-30);
            HttpContext.Current.Response.Cookies.Add(httpCookie);
            ReturnBoolValue = true;
        }
        return ReturnBoolValue;
    }

    /// <summary>
    /// ���cookie
    /// </summary>
    /// <param name="cookieName"></param>c
    /// <returns></returns>
    public static bool DeleteCookie(string cookieName, string domain, string path)
    {
        bool ReturnBoolValue = false;
        HttpCookie httpCookie = new HttpCookie(cookieName);
        if (httpCookie != null)
        {
            httpCookie.Domain = domain;
            httpCookie.Path = path;
            httpCookie.Expires = DateTime.Now.AddDays(-30);
            HttpContext.Current.Response.Cookies.Add(httpCookie);
            ReturnBoolValue = true;
        }
        return ReturnBoolValue;
    }
}

