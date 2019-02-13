// pages/myorder/myorder.js
Page({

  /**
   * 页面的初始数据
   */
  data: {
    activeIndex: 0,
    navList: [],
    order: {},
    prompt: {
      hidden: !0,
      icon: '../../../assets/images/iconfont-order-default.png',
      title: '您还没有相关的订单',
      text: '可以去看看有哪些想买的',
    },
  },
  onLoad() {
    this.order = App.HttpResource('/order/:id', { id: '@id' })
    this.setData({
      navList: [
        {
          name: '全部',
          _id: 'all',
        },
        {
          name: '已提交',
          _id: 'submitted',
        },
        {
          name: '已确认',
          _id: 'confirmed',
        },
        {
          name: '已完成',
          _id: 'finished',
        },
        {
          name: '已取消',
          _id: 'canceled',
        },
      ]
    })
    
  },
  onShow() {
    this.onPullDownRefresh()
  },
  initData() {
    const order = this.data.order
    const params = order && order.params
    const type = params && params.type || 'all'

    this.setData({
      order: {
        items: [],
        params: {
          page: 1,
          limit: 10,
          type: type,
        },
        paginate: {}
      }
    })
  },
  navigateTo(e) {
    console.log(e)
    App.WxService.navigateTo('/pages/wode/wode', {
      id: e.currentTarget.dataset.id
    })
  },
  getOrderList() {
    const order = this.data.order
    const params = order.params

    // App.HttpService.getOrderList(params)
    this.order.queryAsync(params)
      .then(data => {
        console.log(data)
        if (data.meta.code == 0) {
          order.items = [...order.items, ...data.data.items]
          order.paginate = data.data.paginate
          order.params.page = data.data.paginate.next
          order.params.limit = data.data.paginate.perPage
          this.setData({
            order: order,
            'prompt.hidden': order.items.length,
          })
        }
      })
  },
  onPullDownRefresh() {
    this.initData()
    this.getOrderList()
  },
  onReachBottom() {
    this.lower()
  },
  lower() {
    if (!this.data.order.paginate.hasNext) return
    this.getOrderList()
  },
  onTapTag(e) {
    const type = e.currentTarget.dataset.type
    const index = e.currentTarget.dataset.index
    this.initData()
    this.setData({
      activeIndex: index,
      'order.params.type': type,
    })
    this.getOrderList()
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
  }
})