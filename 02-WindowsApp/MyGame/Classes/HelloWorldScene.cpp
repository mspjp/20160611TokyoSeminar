#include "HelloWorldScene.h"

USING_NS_CC;

Scene* HelloWorld::createScene()
{
    // 'scene' is an autorelease object
    auto scene = Scene::create();
    
    // 'layer' is an autorelease object
    auto layer = HelloWorld::create();

    // add layer as a child to scene
    scene->addChild(layer);

    // return the scene
    return scene;
}

// HelloWorldシーンが開始されたとき最初に実行される
bool HelloWorld::init()
{
    if ( !Layer::init() )
    {
        return false;
    }
    //画面サイズを取得
    Size visibleSize = Director::getInstance()->getVisibleSize();
    Vec2 origin = Director::getInstance()->getVisibleOrigin();

	//画像を読み込み
	//読み込む画像はResourceフォルダに入っている
	auto sprite1 = Sprite::create("sampleimage.png");

	//サイズや位置の指定
	sprite1->setScale(0.2,0.2);
	sprite1->setPosition(visibleSize.width/2,visibleSize.height/2);
	

	//タッチイベントのリスナーを取得
	auto listener = EventListenerTouchOneByOne::create();
	//タッチが開始されたとき
	listener->onTouchBegan = [](Touch* touch, Event* event) -> bool {
		return true;
	};
	//タッチが終了したとき
	listener->onTouchEnded = [](Touch* touch, Event* event) -> bool {
		auto touchLocation = touch->getLocation();
		auto sprite = (Sprite*)event->getCurrentTarget();
		auto box = sprite->getBoundingBox();
		if (box.containsPoint(touchLocation)) {
			auto pos = sprite->getPosition();
			sprite->setPosition(pos.x+1,pos.y);
			sprite->setRotation(sprite->getRotation()+1);
		}
		return true;
	};
	
	//タッチイベントリスナーを登録
	//登録先は画像に登録する(画像以外の場所でタッチイベントが反応しない)
	this->getEventDispatcher()->addEventListenerWithSceneGraphPriority(listener, sprite1);
    
	//画像を子要素として追加
	this->addChild(sprite1, 0);

    return true;
}


void HelloWorld::menuCloseCallback(Ref* pSender)
{
    Director::getInstance()->end();

#if (CC_TARGET_PLATFORM == CC_PLATFORM_IOS)
    exit(0);
#endif
}
