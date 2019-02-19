// pages/myorder/myorder.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
  },
  tabClick: function (e) {
    var that = this;
    console.log(e.currentTarget.dataset.ids)
      wx.request({
        url: 'http://localhost:61966/api/Personal/GetNewOrdersByStatu?id=' + e.currentTarget.dataset.ids,
        method: 'get',
        success: function (res) {
          console.log(res.data)
          that.setData({
            orders:res.data
          })
        }
      })
  },
  



  
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that = this;
    wx.request({
      url: 'http://localhost:61966/api/Personal/GetNewOrdersByStatu?id=0',
      method: 'get',
      success: function (res) {
        console.log(res.data)
        that.setData({
          orders: res.data
        })
      }
    })
  },

  /**
   * 生命周期函数--监听页面初次渲染完成
   */
  onReady: function () {

  },

  /**
   * 生命周期函数--监听页面显示
   */
  onShow: function () {
  },

  /**
   * 生命周期函数--监听页面隐藏
   */
  onHide: function () {

  },

  /**
   * 生命周期函数--监听页面卸载
   */
  onUnload: function () {

  },

  /**
   * 页面相关事件处理函数--监听用户下拉动作
   */
  onPullDownRefresh: function () {

  },

  /**
   * 页面上拉触底事件的处理函数
   */
  onReachBottom: function () {

  },

  /**
   * 用户点击右上角分享
   */
  onShareAppMessage: function () {

  },

  Topayy: function (e) {
    var that = this;
    console.log(e.currentTarget.dataset.idpay)
    wx.request({
      url: 'http://localhost:61966/api/Personal/PayInformation?id='+e.currentTarget.dataset.idpay,
      method: 'get',
      success: function (res) {
          if(res.data>0)
          {
            that.onLoad();
            wx.showToast({
              title: '支付成功',
              icon:'success',
              duration:2000
            })
            
          }
          else
          {
            wx.showToast({
              title: '支付失败',
              icon:'default',
              duration:2000
            })
          }
      }
    })
  },
  remind:function(e){
    wx.request({
      url: 'http://localhost:61966/api/Personal/Remind?id=' + e.currentTarget.dataset.remindd,
      method:'get',
      success:function(res) {
        if(res.data>0)
        {
          wx.showToast({
            title: '已提醒商家',
            icon:"success",
            duration:2000
          })
          that.onLoad();
        }
        else
        {
          wx.showToast({
            title: '提醒失败',
            icon:'default',
            duration:2000
          })
        }
      }
    })
  },
  quxiao: function (e) {
    wx.showModal({
      title: '提示',
      content: '是否确认取消订单',
      success:function(res){
        if(res.confirm)
        {
          wx.request({
            url: 'http://localhost:61966/api/Personal/DeleteOrderID?id=' + e.currentTarget.dataset.idpayy,
            method: 'get',
            success: function (res) {
              if (res.data > 0) {
                wx.showToast({
                  title: '已取消订单',
                  icon: "success",
                  duration: 2000
                })
                that.onLoad();
              }
              else {
                wx.showToast({
                  title: '取消失败',
                  icon: 'default',
                  duration: 2000
                })
              }
            }
          })
        }
        else
        {

        }
      }
    }) 
    console.log(e.currentTarget.dataset.idpayy)
    
  },
  querenshou:function(e){
    var that = this;
    wx.showModal({
      title: '提示',
      content: '是否确认收货',
      success:function(res){
        if(res.confirm)
        {
          wx.request({
            url: 'http://localhost:61966/api/Personal/Payment?id=' + e.currentTarget.dataset.idpay,
            method: 'get',
            success: function (res) {
              if (res.data > 0) {
                wx.showToast({
                  title: '已确认收货',
                  icon: 'success',
                  duration: 2000
                })
                that.onLoad();
              }
              else {
                wx.showToast({
                  title: '确认失败，请重试',
                  icon: 'default',
                  duration: 2000
                })
              }
            }
          })
        }
        else
        {

        }
      }
    })
    
  },
  getstates:function(e){
    console.log(111111);
    var that=this;
    var getid=e.currentTarget.dataset.ids;
    wx.request({
      url: 'http://localhost:61966/api/Personal/GetNewOrders?id='+getid,
      method:'get',
      // data:{id:getid},
      success:function(res){
        console.log(111111);
      that.setData({
       aaaaaa:res.data
     })
        console.log(that.data.items.ID)
        console.log(that.data.items.OrderID)
        wx.request({
          url: 'http://localhost:61966/api/Personal/GetProductByOrderID',
          method:'get',
          data: { id: res.data.items.ID, orderid: res.data.items.OrderID},
          success:function(res1) {
           that.setData({
             items1:res1.data
           })
          }
        })
      }
    })
  },
  //删除
  delorder:function(){
  var that=this;
  var getid=e.currentTarget.dataset.ids;
  console.log(getid);
  wx.request({
    url: 'http://localhost:61966/api/Personal/GetDeleteById',
    method:'get',
    data:{id:getid},
    success:function (res){
      if(res.data>0)
      {
      wx.showToast({
        title: '删除成功',
        icon:'success',
        duration:2000
      })
      that.onLoad();
      }
      else{
        wx.showToast({
          title: '删除失败',
          icon:'default',
          duration:2000
        })
      }
    }
  })
  }
})