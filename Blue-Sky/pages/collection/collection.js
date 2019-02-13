// pages/collection/collection.js
Page({

  /**
   * 页面的初始数据
   */
  data: {

  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {
    var that=this;
    wx.request({
      url: 'http://localhost:61966/api/Personal/GetCollectionInfoList',
      method:'get',
      success:function (res) {
        console.log(res.data)
        that.setData({
          items:res.data
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
//根据ID 删除收藏商品
deletesc:function(e) {
var that=this;
  var getid = e.currentTarget.dataset.ids;
  console.log(getid);
  wx.request({
    url: 'http://localhost:61966/api/Personal/GetDeleteById',
    method:'get',
    data: { id: getid},
    success:function (res)
    { 
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