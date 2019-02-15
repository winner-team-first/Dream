// pages/GG/GG.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    categories: [{ id: 1, name: "全部" }, { id: 2 ,name: "待支付" }, { id: 3, name: "待收货" }, { id: 4, name: "待发货"}],
    text:0
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {

  },
  tabClick: function (e) {
    var that = this;
    that.setData({
      text: e.currentTarget.dataset.id
      
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

  }
})