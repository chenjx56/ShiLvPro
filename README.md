# ShiLvPro

基于 ASP.NET Web (.NET Framwork) 开发的环保主题网站

## 前言

年代久远，很多细节已经忘记，这里仅介绍如何在`Visual Studio 2017`上运行本项目

本项目需要下载`SQL Server`创建数据库 （推荐2012年版，其它版本有无问题，没试过）



## 使用

- 首先，利用SQLFile目录下的文件在SQL Server上创建数据库。

- 使用Visual Studio 2017打开`ShiLvPro`
- 在解决方案中，删除`Models目录下的ShiLv.edmx与App.Config`
- 在解决方案中，右键Models，添加新建项，ADO.NET实体数据模型（名称为ShiLv）
- 选择来自数据库的EF设计器，新建连接，服务器名：.，数据库名：ShiLvDB，下一步
- 包括：表、视图、存储过程和函数，创建
- 复制`Models`目录下，`App.Config`中的`connectionStrings`
- 替换`ShiLv.WebUI`目录下的`Web.config`中的`connectionStrings`
- 有兴趣可以研究`Models`目录下`CryptoMethod.cs`中的加密、解密数据库连接字符串的方法，这里为了方便取消加密。修改`Web.config`中的`ConStringEncrypt`的`value`为`false`

启动项目（要安装什么包的话，就根据报错按吧，都不太记得了）



## 功能

- 注册与登录
- 个人中心
- 论坛
- 垃圾分类
- 新闻资讯
- 紧急求助的发布与响应
- 商城购物
- 作品分享与评论
- 活动的发布与参与
- 知识竞答
- 后台管理

## 页面展示
![image](https://user-images.githubusercontent.com/54338601/194858271-eb2e7cd3-a88d-4321-84eb-a2e40993462d.png)
![image](https://user-images.githubusercontent.com/54338601/194858342-70f8cb65-0123-4b87-88b9-d4e0385858e1.png)
![image](https://user-images.githubusercontent.com/54338601/194858507-0a740185-d2d2-4eae-b004-11b5693baf6d.png)
![image](https://user-images.githubusercontent.com/54338601/194858585-4db51209-8ef1-4fb4-86ee-d87249bc6857.png)
![image](https://user-images.githubusercontent.com/54338601/194858627-a4581cb1-5e62-43a6-be8a-5fbbe550f74b.png)
![image](https://user-images.githubusercontent.com/54338601/194858656-ef46d62f-778f-45b5-a4d6-0007ce3fc8f9.png)
![image](https://user-images.githubusercontent.com/54338601/194858689-f00dc204-9fa0-4cec-983c-f0ca98aa55c6.png)
![image](https://user-images.githubusercontent.com/54338601/194858784-fcae0dc2-830b-4e3a-800e-47610f7dbdf2.png)



