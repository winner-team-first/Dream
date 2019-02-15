// pages/myorder/myorder.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    categories: [{name:"全部"},{ id: 1, name: "待支付" }, { id: 2, name: "待发货" }, { id: 3, name: "待收货" }, { id: 4, name: "已取消" }],
    text: 0
  },
  onLoad() {
  },
  tabClick: function (e) {
    var that = this;
      wx.request({
        url: 'http://localhost:61966/api/Personal/GetNewOrders?id=' + e.currentTarget.dataset.id,
        method: 'get',
        success: function (res) {
          that.setData({
            items: res.data
          })
        }
      })
  },
  
  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
   
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

 getAllorders: function (options) {
    var that = this;
    wx.request({
      url: 'http://localhost:61966/api/Personal/GetAllorders',
      method: 'get',
      success: function (res) {
        console.log(res.data)
        that.setData({
          items: res.data
        })
      }
    })
  },
  getstates:function(e){
    var that=this;
    var getid=e.currentTarget.dataset.ids;
    wx.request({
      url: 'http://localhost:61966/api/Personal/GetNewOrders',
      method:'get',
      data:{id:getid},
      success:function(res){
        that.setData({
          items:res.data
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